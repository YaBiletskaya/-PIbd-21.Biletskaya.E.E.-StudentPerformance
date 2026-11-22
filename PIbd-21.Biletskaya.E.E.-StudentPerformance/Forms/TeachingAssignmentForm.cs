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
    public partial class TeachingAssignmentForm : Form
    {
        private readonly ITeachingAssignmentRepository _assignmentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger _logger;

        public TeachingAssignmentForm(
            ITeachingAssignmentRepository assignmentRepository,
            ITeacherRepository teacherRepository,
            IDepartmentRepository departmentRepository, ILogger logger)
        {
            InitializeComponent();

            _assignmentRepository = assignmentRepository;
            _teacherRepository = teacherRepository;
            _departmentRepository = departmentRepository;
            _logger = logger;
            _logger.LogInformation("Открыта форма назначений преподавателей");

            buttonAdd.Click += buttonAdd_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            LoadAssignments();
        }

        private void LoadAssignments()
        {
            _logger.LogInformation("Загрузка списка назначений преподавателей");

            dataGridViewAssignments.DataSource = null;

            dataGridViewAssignments.DataSource =
                _assignmentRepository.ReadAll()
                    .Select(assignment => new
                    {
                        assignment.Id,
                        Teacher = _teacherRepository
                            .ReadById(assignment.TeacherId) is Teacher teacher
                                ? $"{teacher.LastName} {teacher.FirstName} {teacher.MiddleName}".Trim()
                                : "Не указан",
                        Department = _departmentRepository
                            .ReadById(assignment.DepartmentId)?.Name ?? "Не указана",
                        assignment.AssignmentDate
                    })
                    .ToList();

            if (dataGridViewAssignments.Columns.Count > 0)
            {
                dataGridViewAssignments.Columns[nameof(TeachingAssignment.Id)].HeaderText =
                    "ID";
                dataGridViewAssignments.Columns["Teacher"].HeaderText =
                    "Преподаватель";
                dataGridViewAssignments.Columns["Department"].HeaderText =
                    "Кафедра";
                dataGridViewAssignments.Columns[nameof(TeachingAssignment.AssignmentDate)]
                    .HeaderText = "Дата назначения";
            }
        }

        private TeachingAssignment? GetSelectedAssignment()
        {
            if (dataGridViewAssignments.CurrentRow == null)
                return null;

            int id = Convert.ToInt32(
                dataGridViewAssignments.CurrentRow.Cells[
                    nameof(TeachingAssignment.Id)].Value);

            return _assignmentRepository.ReadById(id);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал создание назначения преподавателя");

            if (!_teacherRepository.ReadAll().Any())
            {
                MessageBox.Show("Сначала добавьте преподавателя.");
                return;
            }

            if (!_departmentRepository.ReadAll().Any())
            {
                MessageBox.Show("Сначала добавьте кафедру.");
                return;
            }

            using TeachingAssignmentEditForm editForm =
                new TeachingAssignmentEditForm(
                    _teacherRepository,
                    _departmentRepository);

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Assignment != null)
            {
                int id = _assignmentRepository.ReadAll()
                    .Select(item => item.Id)
                    .DefaultIfEmpty(0)
                    .Max() + 1;

                TeachingAssignment assignment = TeachingAssignment.CreateEntity(
                    id,
                    editForm.Assignment.TeacherId,
                    editForm.Assignment.DepartmentId,
                    editForm.Assignment.AssignmentDate);

                _assignmentRepository.Create(assignment);
                _logger.LogInformation(
                "Создано назначение преподавателя. ID: {AssignmentId}, ID преподавателя: {TeacherId}, ID кафедры: {DepartmentId}",
                assignment.Id,
                assignment.TeacherId,
                assignment.DepartmentId);
                LoadAssignments();
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал удаление назначения преподавателя");

            TeachingAssignment? assignment = GetSelectedAssignment();

            if (assignment == null)
            {
                MessageBox.Show("Выберите назначение для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить выбранное назначение преподавателя?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _assignmentRepository.Delete(assignment.Id);
                _logger.LogInformation(
                "Удалено назначение преподавателя. ID: {AssignmentId}",
                assignment.Id);
                LoadAssignments();
            }
        }

        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Обновление списка назначений преподавателей");
            LoadAssignments();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Закрыта форма назначений преподавателей");
            Close();
        }
    }
}
