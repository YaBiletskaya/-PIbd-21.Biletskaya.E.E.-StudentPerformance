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
    public partial class StudentForm : Form
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger _logger;

        public StudentForm(
            IStudentRepository studentRepository,
            IDepartmentRepository departmentRepository, ILogger logger)
        {
            InitializeComponent();

            _studentRepository = studentRepository;
            _departmentRepository = departmentRepository;
            _logger = logger;
            _logger.LogInformation("Открыта форма управления студентами");

            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            LoadStudents();
        }

        private void LoadStudents()
        {
            _logger.LogInformation("Загрузка списка студентов");

            dataGridViewStudents.DataSource = null;

            dataGridViewStudents.DataSource =
                _studentRepository.ReadAll()
                    .Select(student => new
                    {
                        student.Id,
                        Department = _departmentRepository
                            .ReadById(student.DepartmentId)?.Name ?? "Не указана",
                        student.LastName,
                        student.FirstName,
                        student.MiddleName,
                        student.StudentNumber,
                        student.BirthDate,
                        student.StreamName,
                        student.GroupName,
                        student.AdmissionYear
                    })
                    .ToList();

            if (dataGridViewStudents.Columns.Count > 0)
            {
                dataGridViewStudents.Columns[nameof(Student.Id)].HeaderText = "ID";
                dataGridViewStudents.Columns["Department"].HeaderText = "Кафедра";
                dataGridViewStudents.Columns[nameof(Student.LastName)].HeaderText =
                    "Фамилия";
                dataGridViewStudents.Columns[nameof(Student.FirstName)].HeaderText =
                    "Имя";
                dataGridViewStudents.Columns[nameof(Student.MiddleName)].HeaderText =
                    "Отчество";
                dataGridViewStudents.Columns[nameof(Student.StudentNumber)].HeaderText =
                    "Номер студенческого";
                dataGridViewStudents.Columns[nameof(Student.BirthDate)].HeaderText =
                    "Дата рождения";
                dataGridViewStudents.Columns[nameof(Student.StreamName)].HeaderText =
                    "Поток";
                dataGridViewStudents.Columns[nameof(Student.GroupName)].HeaderText =
                    "Группа";
                dataGridViewStudents.Columns[nameof(Student.AdmissionYear)].HeaderText =
                    "Год поступления";
            }
        }

        private Student? GetSelectedStudent()
        {
            if (dataGridViewStudents.CurrentRow == null)
                return null;

            int id = Convert.ToInt32(
                dataGridViewStudents.CurrentRow.Cells[nameof(Student.Id)].Value);

            return _studentRepository.ReadById(id);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал добавление студента");

            if (!_departmentRepository.ReadAll().Any())
            {
                MessageBox.Show("Сначала добавьте кафедру.");
                return;
            }

            using StudentEditForm editForm =
                new StudentEditForm(_departmentRepository);

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Student != null)
            {
                int id = _studentRepository.ReadAll()
                    .Select(item => item.Id)
                    .DefaultIfEmpty(0)
                    .Max() + 1;

                Student student = Student.CreateEntity(
                    id,
                    editForm.Student.DepartmentId,
                    editForm.Student.FirstName,
                    editForm.Student.LastName,
                    editForm.Student.MiddleName,
                    editForm.Student.StudentNumber,
                    editForm.Student.BirthDate,
                    editForm.Student.StreamName,
                    editForm.Student.GroupName,
                    editForm.Student.AdmissionYear);

                _studentRepository.Create(student);
                _logger.LogInformation(
                "Добавлен студент. ID: {StudentId}, ФИО: {LastName} {FirstName}",
                student.Id,
                student.LastName,
                student.FirstName);
                LoadStudents();
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал изменение данных студента");

            Student? student = GetSelectedStudent();

            if (student == null)
            {
                MessageBox.Show("Выберите студента для изменения.");
                return;
            }

            using StudentEditForm editForm =
                new StudentEditForm(_departmentRepository, student);

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Student != null)
            {
                _studentRepository.Update(editForm.Student);
                _logger.LogInformation(
                "Изменены данные студента. ID: {StudentId}",
                editForm.Student.Id);
                LoadStudents();
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал удаление студента");

            Student? student = GetSelectedStudent();

            if (student == null)
            {
                MessageBox.Show("Выберите студента для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Удалить студента «{student.LastName} {student.FirstName}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _studentRepository.Delete(student.Id);
                _logger.LogInformation(
                "Удален студент. ID: {StudentId}, ФИО: {LastName} {FirstName}",
                student.Id,
                student.LastName,
                student.FirstName);
                LoadStudents();
            }
        }

        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Обновление списка студентов");
            LoadStudents();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Закрыта форма управления студентами");
            Close();
        }
    }
}
