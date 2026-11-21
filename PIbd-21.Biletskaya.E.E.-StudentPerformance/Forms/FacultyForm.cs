using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;
using Microsoft.Extensions.Logging;
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
    public partial class FacultyForm : Form
    {
        private readonly IFacultyRepository _facultyRepository;
        private readonly ILogger _logger;

        public FacultyForm(
            IFacultyRepository facultyRepository,
            ILogger logger)
        {
            InitializeComponent();

            _facultyRepository = facultyRepository;
            _logger = logger;

            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            _logger.LogInformation("Открыта форма списка факультетов");

            LoadFaculties();
        }

        private void LoadFaculties()
        {
            try
            {
                dataGridViewFaculties.DataSource = null;
                dataGridViewFaculties.DataSource = _facultyRepository.ReadAll()
                    .Select(faculty => new
                    {
                        faculty.Id,
                        faculty.Name,
                        faculty.DeanFullName
                    })
                    .ToList();

                dataGridViewFaculties.Columns[nameof(Faculty.Name)].HeaderText =
                    "Название факультета";

                dataGridViewFaculties.Columns[nameof(Faculty.DeanFullName)].HeaderText =
                    "ФИО декана";

                _logger.LogInformation(
                    "Список факультетов успешно загружен. Количество: {Count}",
                    dataGridViewFaculties.Rows.Count);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при загрузке списка факультетов");

                MessageBox.Show(
                    "Не удалось загрузить список факультетов:\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Faculty? GetSelectedFaculty()
        {
            if (dataGridViewFaculties.CurrentRow == null)
            {
                return null;
            }

            int id = Convert.ToInt32(
                dataGridViewFaculties.CurrentRow.Cells[nameof(Faculty.Id)].Value);

            return _facultyRepository.ReadById(id);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                using FacultyEditForm editForm = new FacultyEditForm();

                if (editForm.ShowDialog(this) == DialogResult.OK &&
                    editForm.Faculty != null)
                {
                    Faculty faculty = Faculty.CreateEntity(
                        _facultyRepository.ReadAll()
                            .Select(item => item.Id)
                            .DefaultIfEmpty(0)
                            .Max() + 1,
                        editForm.Faculty.Name,
                        editForm.Faculty.DeanFullName);

                    _facultyRepository.Create(faculty);

                    _logger.LogInformation(
                        "Добавлен факультет с ID {FacultyId}: {FacultyName}",
                        faculty.Id,
                        faculty.Name);

                    LoadFaculties();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении факультета");

                MessageBox.Show(
                    "Не удалось добавить факультет:\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            try
            {
                Faculty? faculty = GetSelectedFaculty();

                if (faculty == null)
                {
                    MessageBox.Show("Выберите факультет для изменения.");
                    return;
                }

                using FacultyEditForm editForm = new FacultyEditForm(faculty);

                if (editForm.ShowDialog(this) == DialogResult.OK &&
                    editForm.Faculty != null)
                {
                    _facultyRepository.Update(editForm.Faculty);

                    _logger.LogInformation(
                        "Изменён факультет с ID {FacultyId}: {FacultyName}",
                        editForm.Faculty.Id,
                        editForm.Faculty.Name);

                    LoadFaculties();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при изменении факультета");

                MessageBox.Show(
                    "Не удалось изменить факультет:\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                Faculty? faculty = GetSelectedFaculty();

                if (faculty == null)
                {
                    MessageBox.Show("Выберите факультет для удаления.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Удалить факультет «{faculty.Name}»?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _facultyRepository.Delete(faculty.Id);

                    _logger.LogInformation(
                        "Удалён факультет с ID {FacultyId}: {FacultyName}",
                        faculty.Id,
                        faculty.Name);

                    LoadFaculties();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении факультета");

                MessageBox.Show(
                    "Не удалось удалить факультет:\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Выполнено обновление списка факультетов");
            LoadFaculties();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Закрыта форма списка факультетов");
            Close();
        }
    }
}
