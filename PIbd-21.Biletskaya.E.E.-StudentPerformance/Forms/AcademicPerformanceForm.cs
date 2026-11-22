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
    public partial class AcademicPerformanceForm : Form
    {
        private readonly IAcademicPerformanceRepository _performanceRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ITeachingAssignmentDisciplineRepository _assignmentDisciplineRepository;
        private readonly ITeachingAssignmentRepository _assignmentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDisciplineRepository _disciplineRepository;
        private readonly ILogger _logger;

        public AcademicPerformanceForm(
            IAcademicPerformanceRepository performanceRepository,
            IStudentRepository studentRepository,
            ITeachingAssignmentDisciplineRepository assignmentDisciplineRepository,
            ITeachingAssignmentRepository assignmentRepository,
            ITeacherRepository teacherRepository,
            IDisciplineRepository disciplineRepository, ILogger logger)
        {
            InitializeComponent();

            _performanceRepository = performanceRepository;
            _studentRepository = studentRepository;
            _assignmentDisciplineRepository = assignmentDisciplineRepository;
            _assignmentRepository = assignmentRepository;
            _teacherRepository = teacherRepository;
            _disciplineRepository = disciplineRepository;
            _logger = logger;
            _logger.LogInformation("Открыта форма учета успеваемости");

            ConfigureGrid();

            buttonAdd.Click -= buttonAdd_Click;
            buttonAdd.Click += buttonAdd_Click;

            buttonDelete.Click -= buttonDelete_Click;
            buttonDelete.Click += buttonDelete_Click;

            buttonRefresh.Click -= buttonRefresh_Click;
            buttonRefresh.Click += buttonRefresh_Click;

            buttonClose.Click -= buttonClose_Click;
            buttonClose.Click += buttonClose_Click;

            LoadPerformance();
        }

        private void ConfigureGrid()
        {
            dataGridViewPerformance.Columns.Clear();

            dataGridViewPerformance.ReadOnly = true;
            dataGridViewPerformance.AllowUserToAddRows = false;
            dataGridViewPerformance.AllowUserToDeleteRows = false;
            dataGridViewPerformance.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPerformance.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPerformance.MultiSelect = false;
            dataGridViewPerformance.RowHeadersVisible = false;

            dataGridViewPerformance.Columns.Add("Id", "ID");
            dataGridViewPerformance.Columns.Add("Student", "Студент");
            dataGridViewPerformance.Columns.Add("Group", "Группа");
            dataGridViewPerformance.Columns.Add("Discipline", "Дисциплина");
            dataGridViewPerformance.Columns.Add("Teacher", "Преподаватель");
            dataGridViewPerformance.Columns.Add("AcademicYear", "Учебный год");
            dataGridViewPerformance.Columns.Add("Semester", "Семестр");
            dataGridViewPerformance.Columns.Add("Grade", "Оценка");
            dataGridViewPerformance.Columns.Add("Options", "Вид контроля");
            dataGridViewPerformance.Columns.Add("AssessmentDate", "Дата");

            dataGridViewPerformance.Columns["Id"]!.Visible = false;
        }

        private void LoadPerformance()
        {
            dataGridViewPerformance.Rows.Clear();
            _logger.LogInformation("Загрузка списка успеваемости");

            var students = _studentRepository.ReadAll().ToList();
            var assignmentDisciplines =
                _assignmentDisciplineRepository.ReadAll().ToList();
            var assignments = _assignmentRepository.ReadAll().ToList();
            var teachers = _teacherRepository.ReadAll().ToList();
            var disciplines = _disciplineRepository.ReadAll().ToList();

            foreach (var performance in _performanceRepository.ReadAll())
            {
                var student = students.FirstOrDefault(
                    x => x.Id == performance.StudentId);

                var assignmentDiscipline = assignmentDisciplines.FirstOrDefault(
                    x => x.Id == performance.TeachingAssignmentDisciplineId);

                if (student == null || assignmentDiscipline == null)
                    continue;

                var assignment = assignments.FirstOrDefault(
                    x => x.Id == assignmentDiscipline.TeachingAssignmentId);

                if (assignment == null)
                    continue;

                var teacher = teachers.FirstOrDefault(
                    x => x.Id == assignment.TeacherId);

                var discipline = disciplines.FirstOrDefault(
                    x => x.Id == assignmentDiscipline.DisciplineId);

                if (teacher == null || discipline == null)
                    continue;

                string studentName =
                    $"{student.LastName} {student.FirstName} {student.MiddleName}";

                string teacherName =
                    $"{teacher.LastName} {teacher.FirstName} {teacher.MiddleName}";

                dataGridViewPerformance.Rows.Add(
                    performance.Id,
                    studentName,
                    student.GroupName,
                    discipline.Name,
                    teacherName,
                    performance.AcademicYear,
                    performance.Semester,
                    performance.Grade,
                    FormatOptions(performance.Options),
                    performance.AssessmentDate.ToShortDateString());
            }
        }

        private string FormatOptions(AssessmentOptions options)
        {
            var names = new System.Collections.Generic.List<string>();

            if (options.HasFlag(AssessmentOptions.Exam))
                names.Add("Экзамен");

            if (options.HasFlag(AssessmentOptions.Credit))
                names.Add("Зачёт");

            if (options.HasFlag(AssessmentOptions.DifferentiatedCredit))
                names.Add("Дифференцированный зачёт");

            if (options.HasFlag(AssessmentOptions.Coursework))
                names.Add("Курсовая работа");

            if (options.HasFlag(AssessmentOptions.PracticalWork))
                names.Add("Практическая работа");

            return names.Count > 0
                ? string.Join(", ", names)
                : "Не указан";
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал добавление оценки");

            int newId = _performanceRepository.ReadAll()
                .Select(x => x.Id)
                .DefaultIfEmpty(0)
                .Max() + 1;

            using var editForm = new AcademicPerformanceEditForm(
                _studentRepository,
                _assignmentDisciplineRepository,
                _assignmentRepository,
                _teacherRepository,
                _disciplineRepository);

            editForm.NewId = newId;

            if (editForm.ShowDialog() == DialogResult.OK &&
                editForm.Performance != null)
            {
                _performanceRepository.Create(editForm.Performance);
                _logger.LogInformation(
                "Добавлена оценка. ID: {PerformanceId}, студент: {StudentId}",
                editForm.Performance.Id,
                editForm.Performance.StudentId);
                LoadPerformance();
            }
        }


        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал удаление оценки");

            if (dataGridViewPerformance.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Выберите оценку для удаления.",
                    "Удаление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(
                dataGridViewPerformance.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить выбранную оценку?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _performanceRepository.Delete(id);

                _logger.LogInformation("Удалена оценка. ID: {PerformanceId}", id);

                MessageBox.Show(
                    "Оценка успешно удалена.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadPerformance();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка базы данных при удалении оценки. ID: {PerformanceId}",
                    id);

                MessageBox.Show(
                    "Не удалось удалить оценку из базы данных.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка при удалении оценки. ID: {PerformanceId}",
                    id);

                MessageBox.Show(
                    "Произошла ошибка при удалении оценки.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Обновление списка успеваемости");
            LoadPerformance();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Закрыта форма учета успеваемости"); 
            Close();
        }
    }
}
