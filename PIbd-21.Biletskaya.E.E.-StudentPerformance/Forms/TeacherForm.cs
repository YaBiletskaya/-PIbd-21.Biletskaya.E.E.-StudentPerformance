using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities.Enums;
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
    public partial class TeacherForm : Form
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly ILogger _logger;

        public TeacherForm(ITeacherRepository teacherRepository, ILogger logger)
        {
            InitializeComponent();

            _teacherRepository = teacherRepository;
            _logger = logger;
            _logger.LogInformation("Открыта форма управления преподавателями");

            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            LoadTeachers();
        }

        private void LoadTeachers()
        {
            _logger.LogInformation("Загрузка списка преподавателей");

            dataGridViewTeachers.DataSource = null;

            dataGridViewTeachers.DataSource = _teacherRepository.ReadAll()
                .Select(teacher => new
                {
                    teacher.Id,
                    teacher.LastName,
                    teacher.FirstName,
                    teacher.MiddleName,
                    teacher.AcademicDegree,
                    Position = GetPositionName(teacher.Position)
                })
                .ToList();

            if (dataGridViewTeachers.Columns.Count > 0)
            {
                dataGridViewTeachers.Columns[nameof(Teacher.Id)].HeaderText = "ID";
                dataGridViewTeachers.Columns[nameof(Teacher.LastName)].HeaderText = "Фамилия";
                dataGridViewTeachers.Columns[nameof(Teacher.FirstName)].HeaderText = "Имя";
                dataGridViewTeachers.Columns[nameof(Teacher.MiddleName)].HeaderText = "Отчество";
                dataGridViewTeachers.Columns[nameof(Teacher.AcademicDegree)].HeaderText =
                    "Учёная степень";
                dataGridViewTeachers.Columns["Position"].HeaderText = "Должность";
            }
        }

        private string GetPositionName(TeacherPosition position)
        {
            return position switch
            {
                TeacherPosition.None => "Не указана",
                TeacherPosition.Assistant => "Ассистент",
                TeacherPosition.Lecturer => "Преподаватель",
                TeacherPosition.SeniorLecturer => "Старший преподаватель",
                TeacherPosition.AssociateProfessor => "Доцент",
                TeacherPosition.Professor => "Профессор",
                TeacherPosition.HeadOfDepartment => "Заведующий кафедрой",
                _ => "Неизвестная должность"
            };
        }

        private Teacher? GetSelectedTeacher()
        {
            if (dataGridViewTeachers.CurrentRow == null)
                return null;

            int id = Convert.ToInt32(
                dataGridViewTeachers.CurrentRow.Cells[nameof(Teacher.Id)].Value);

            return _teacherRepository.ReadById(id);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал добавление преподавателя");

            using TeacherEditForm editForm = new TeacherEditForm();

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Teacher != null)
            {
                int id = _teacherRepository.ReadAll()
                    .Select(item => item.Id)
                    .DefaultIfEmpty(0)
                    .Max() + 1;

                Teacher teacher = Teacher.CreateEntity(
                    id,
                    editForm.Teacher.FirstName,
                    editForm.Teacher.LastName,
                    editForm.Teacher.MiddleName,
                    editForm.Teacher.AcademicDegree,
                    editForm.Teacher.Position);

                _teacherRepository.Create(teacher);
                _logger.LogInformation(
                "Добавлен преподаватель. ID: {TeacherId}, ФИО: {LastName} {FirstName}",
                teacher.Id,
                teacher.LastName,
                teacher.FirstName);
                LoadTeachers();
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал изменение данных преподавателя");

            Teacher? teacher = GetSelectedTeacher();

            if (teacher == null)
            {
                MessageBox.Show("Выберите преподавателя для изменения.");
                return;
            }

            using TeacherEditForm editForm = new TeacherEditForm(teacher);

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Teacher != null)
            {
                _teacherRepository.Update(editForm.Teacher);
                _logger.LogInformation(
                "Изменены данные преподавателя. ID: {TeacherId}",
                editForm.Teacher.Id);
                LoadTeachers();
            }
        }


        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал удаление преподавателя");

            Teacher? teacher = GetSelectedTeacher();

            if (teacher == null)
            {
                MessageBox.Show("Выберите преподавателя для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Удалить преподавателя «{teacher.LastName} {teacher.FirstName}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _teacherRepository.Delete(teacher.Id);

                _logger.LogInformation(
                    "Удален преподаватель. ID: {TeacherId}, ФИО: {LastName} {FirstName}",
                    teacher.Id,
                    teacher.LastName,
                    teacher.FirstName);

                MessageBox.Show(
                    "Преподаватель успешно удален.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTeachers();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogWarning(
                    ex,
                    "Невозможно удалить преподавателя. ID: {TeacherId}: существуют связанные записи",
                    teacher.Id);

                MessageBox.Show(
                    "Невозможно удалить преподавателя, так как с ним связаны учебные назначения.",
                    "Удаление невозможно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка при удалении преподавателя. ID: {TeacherId}",
                    teacher.Id);

                MessageBox.Show(
                    "Произошла ошибка при удалении преподавателя.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Обновление списка преподавателей");
            LoadTeachers();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Закрыта форма управления преподавателями");
            Close();
        }
    }
}
