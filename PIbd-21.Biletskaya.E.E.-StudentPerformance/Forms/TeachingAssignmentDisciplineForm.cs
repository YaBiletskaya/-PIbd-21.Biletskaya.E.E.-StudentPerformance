
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Forms
{
    public partial class TeachingAssignmentDisciplineForm : Form
    {
        private readonly ITeachingAssignmentDisciplineRepository _repository;
        private readonly ITeachingAssignmentRepository _assignmentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IDisciplineRepository _disciplineRepository;
        private readonly ILogger _logger;

        public TeachingAssignmentDisciplineForm(
            ITeachingAssignmentDisciplineRepository repository,
            ITeachingAssignmentRepository assignmentRepository,
            ITeacherRepository teacherRepository,
            IDepartmentRepository departmentRepository,
            IDisciplineRepository disciplineRepository,
            ILogger logger)
        {
            InitializeComponent();

            _repository = repository;
            _assignmentRepository = assignmentRepository;
            _teacherRepository = teacherRepository;
            _departmentRepository = departmentRepository;
            _disciplineRepository = disciplineRepository;
            _logger = logger;

            _logger.LogInformation(
                "Открыта форма закрепления дисциплин за преподавателями");

            buttonAdd.Click += buttonAdd_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            LoadAssignmentDisciplines();
        }

        private void LoadAssignmentDisciplines()
        {
            _logger.LogInformation("Загрузка списка закрепленных дисциплин");

            dataGridViewAssignmentDisciplines.DataSource = null;

            dataGridViewAssignmentDisciplines.DataSource =
                _repository.ReadAll()
                    .Select(item =>
                    {
                        TeachingAssignment? assignment =
                            _assignmentRepository.ReadById(
                                item.TeachingAssignmentId);

                        Teacher? teacher = assignment == null
                            ? null
                            : _teacherRepository.ReadById(
                                assignment.TeacherId);

                        Department? department = assignment == null
                            ? null
                            : _departmentRepository.ReadById(
                                assignment.DepartmentId);

                        Discipline? discipline =
                            _disciplineRepository.ReadById(
                                item.DisciplineId);

                        return new
                        {
                            item.Id,
                            Teacher = teacher == null
                                ? "Не указан"
                                : $"{teacher.LastName} {teacher.FirstName}",
                            Department = department?.Name ?? "Не указана",
                            Discipline = discipline?.Name ?? "Не указана",
                            item.Hours
                        };
                    })
                    .ToList();

            if (dataGridViewAssignmentDisciplines.Columns.Count > 0)
            {
                dataGridViewAssignmentDisciplines.Columns["Id"].HeaderText =
                    "ID";

                dataGridViewAssignmentDisciplines.Columns["Teacher"].HeaderText =
                    "Преподаватель";

                dataGridViewAssignmentDisciplines.Columns["Department"].HeaderText =
                    "Кафедра";

                dataGridViewAssignmentDisciplines.Columns["Discipline"].HeaderText =
                    "Дисциплина";

                dataGridViewAssignmentDisciplines.Columns["Hours"].HeaderText =
                    "Количество часов";
            }
        }

        private TeachingAssignmentDiscipline? GetSelectedItem()
        {
            if (dataGridViewAssignmentDisciplines.CurrentRow == null)
                return null;

            int id = Convert.ToInt32(
                dataGridViewAssignmentDisciplines
                    .CurrentRow.Cells["Id"].Value);

            return _repository.ReadById(id);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation(
                "Пользователь начал закрепление дисциплины за назначением");

            if (!_assignmentRepository.ReadAll().Any())
            {
                MessageBox.Show(
                    "Сначала создайте назначение преподавателя.");
                return;
            }

            if (!_disciplineRepository.ReadAll().Any())
            {
                MessageBox.Show("Сначала добавьте дисциплину.");
                return;
            }

            using TeachingAssignmentDisciplineEditForm editForm =
                new TeachingAssignmentDisciplineEditForm(
                    _assignmentRepository,
                    _teacherRepository,
                    _departmentRepository,
                    _disciplineRepository);

            if (editForm.ShowDialog(this) != DialogResult.OK ||
                editForm.AssignmentDiscipline == null)
                return;

            var newItem = editForm.AssignmentDiscipline;

            bool alreadyExists = _repository.ReadAll().Any(item =>
                item.TeachingAssignmentId == newItem.TeachingAssignmentId &&
                item.DisciplineId == newItem.DisciplineId);

            if (alreadyExists)
            {
                MessageBox.Show(
                    "Эта дисциплина уже закреплена за выбранным назначением.");
                return;
            }

            int id = _repository.ReadAll()
                .Select(item => item.Id)
                .DefaultIfEmpty(0)
                .Max() + 1;

            try
            {
                TeachingAssignmentDiscipline entity =
                    TeachingAssignmentDiscipline.CreateEntity(
                        id,
                        newItem.TeachingAssignmentId,
                        newItem.DisciplineId,
                        newItem.Hours);

                _repository.Create(entity);

                _logger.LogInformation(
                    "Дисциплина закреплена за назначением. ID записи: {Id}, ID назначения: {AssignmentId}, ID дисциплины: {DisciplineId}",
                    entity.Id,
                    entity.TeachingAssignmentId,
                    entity.DisciplineId);

                MessageBox.Show(
                    "Дисциплина успешно закреплена за назначением.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAssignmentDisciplines();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка базы данных при закреплении дисциплины. ID назначения: {AssignmentId}, ID дисциплины: {DisciplineId}",
                    newItem.TeachingAssignmentId,
                    newItem.DisciplineId);

                MessageBox.Show(
                    "Не удалось закрепить дисциплину. Проверьте правильность выбранных данных.",
                    "Ошибка базы данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка при закреплении дисциплины");

                MessageBox.Show(
                    "Произошла ошибка при добавлении записи.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation(
                "Пользователь начал удаление закрепленной дисциплины");

            TeachingAssignmentDiscipline? item = GetSelectedItem();

            if (item == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Удалить выбранную дисциплину из назначения?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _repository.Delete(item.Id);

                _logger.LogInformation(
                    "Удалена запись о закреплении дисциплины. ID: {Id}",
                    item.Id);

                MessageBox.Show(
                    "Закрепление дисциплины успешно удалено.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAssignmentDisciplines();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogWarning(
                    ex,
                    "Невозможно удалить закрепление дисциплины. ID: {Id}: существуют связанные оценки",
                    item.Id);

                MessageBox.Show(
                    "Невозможно удалить закрепление, так как по этой дисциплине уже есть оценки.",
                    "Удаление невозможно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка при удалении закрепления дисциплины. ID: {Id}",
                    item.Id);

                MessageBox.Show(
                    "Произошла ошибка при удалении записи.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation(
                "Обновление списка закрепленных дисциплин");

            LoadAssignmentDisciplines();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation(
                "Закрыта форма закрепления дисциплин");

            Close();
        }
    }
}
