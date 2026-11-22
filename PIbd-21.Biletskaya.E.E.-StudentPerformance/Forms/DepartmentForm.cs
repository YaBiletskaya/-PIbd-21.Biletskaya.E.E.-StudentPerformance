using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    public partial class DepartmentForm : Form
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IFacultyRepository _facultyRepository;
        private readonly ILogger _logger;

        public DepartmentForm(
            IDepartmentRepository departmentRepository,
            IFacultyRepository facultyRepository, ILogger logger)
        {
            InitializeComponent();

            _departmentRepository = departmentRepository;
            _facultyRepository = facultyRepository;
            _logger = logger;
            _logger.LogInformation("Открыта форма управления кафедрами");

            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            LoadDepartments();
        }

        private void LoadDepartments()
        {
            _logger.LogInformation("Загрузка списка кафедр");

            dataGridViewDepartments.DataSource = null;

            dataGridViewDepartments.DataSource =
                _departmentRepository.ReadAll()
                    .Select(department => new
                    {
                        department.Id,
                        Faculty = _facultyRepository.ReadById(department.FacultyId)?.Name
                                  ?? "Не указан",
                        department.Name,
                        department.HeadFullName
                    })
                    .ToList();

            if (dataGridViewDepartments.Columns.Count > 0)
            {
                dataGridViewDepartments.Columns[nameof(Department.Id)].HeaderText = "ID";
                dataGridViewDepartments.Columns["Faculty"].HeaderText = "Факультет";
                dataGridViewDepartments.Columns[nameof(Department.Name)].HeaderText =
                    "Название кафедры";
                dataGridViewDepartments.Columns[nameof(Department.HeadFullName)].HeaderText =
                    "Заведующий";
            }
        }

        private Department? GetSelectedDepartment()
        {
            if (dataGridViewDepartments.CurrentRow == null)
            {
                return null;
            }

            int id = Convert.ToInt32(
                dataGridViewDepartments.CurrentRow.Cells[nameof(Department.Id)].Value);

            return _departmentRepository.ReadById(id);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал добавление кафедры");

            if (!_facultyRepository.ReadAll().Any())
            {
                MessageBox.Show("Сначала добавьте факультет.");
                return;
            }

            using DepartmentEditForm editForm =
                new DepartmentEditForm(_facultyRepository);

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Department != null)
            {
                int id = _departmentRepository.ReadAll()
                    .Select(item => item.Id)
                    .DefaultIfEmpty(0)
                    .Max() + 1;

                Department department = Department.CreateEntity(
                    id,
                    editForm.Department.FacultyId,
                    editForm.Department.Name,
                    editForm.Department.HeadFullName);

                _departmentRepository.Create(department);
                _logger.LogInformation(
                "Добавлена кафедра. ID: {DepartmentId}, название: {DepartmentName}",
                department.Id,
                department.Name);
                LoadDepartments();
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал изменение кафедры");

            Department? department = GetSelectedDepartment();

            if (department == null)
            {
                MessageBox.Show("Выберите кафедру для изменения.");
                return;
            }

            using DepartmentEditForm editForm =
                new DepartmentEditForm(_facultyRepository, department);

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Department != null)
            {
                _departmentRepository.Update(editForm.Department);
                _logger.LogInformation(
                "Изменена кафедра. ID: {DepartmentId}, название: {DepartmentName}",
                editForm.Department.Id,
                editForm.Department.Name);
                LoadDepartments();
            }
        }


        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал удаление кафедры");

            Department? department = GetSelectedDepartment();

            if (department == null)
            {
                MessageBox.Show("Выберите кафедру для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Удалить кафедру «{department.Name}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _departmentRepository.Delete(department.Id);

                _logger.LogInformation(
                    "Удалена кафедра. ID: {DepartmentId}, название: {DepartmentName}",
                    department.Id,
                    department.Name);

                MessageBox.Show(
                    "Кафедра успешно удалена.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDepartments();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogWarning(
                    ex,
                    "Невозможно удалить кафедру. ID: {DepartmentId}: существуют связанные записи",
                    department.Id);

                MessageBox.Show(
                    "Невозможно удалить кафедру, так как с ней связаны студенты или учебные назначения.",
                    "Удаление невозможно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка при удалении кафедры. ID: {DepartmentId}",
                    department.Id);

                MessageBox.Show(
                    "Произошла ошибка при удалении кафедры.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Обновление списка кафедр");
            LoadDepartments();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Закрыта форма управления кафедрами"); 
            Close();
        }
    }
}
