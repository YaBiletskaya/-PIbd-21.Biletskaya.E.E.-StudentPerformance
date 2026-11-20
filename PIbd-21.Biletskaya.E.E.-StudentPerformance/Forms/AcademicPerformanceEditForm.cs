using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities.Enums;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;
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
    public partial class AcademicPerformanceEditForm : Form
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ITeachingAssignmentDisciplineRepository _assignmentDisciplineRepository;
        private readonly ITeachingAssignmentRepository _assignmentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDisciplineRepository _disciplineRepository;

        public AcademicPerformance? Performance { get; private set; }

        // ID новой оценки задаётся из AcademicPerformanceForm.
        public int NewId { get; set; }

        public AcademicPerformanceEditForm(
            IStudentRepository studentRepository,
            ITeachingAssignmentDisciplineRepository assignmentDisciplineRepository,
            ITeachingAssignmentRepository assignmentRepository,
            ITeacherRepository teacherRepository,
            IDisciplineRepository disciplineRepository)
        {
            InitializeComponent();

            _studentRepository = studentRepository;
            _assignmentDisciplineRepository = assignmentDisciplineRepository;
            _assignmentRepository = assignmentRepository;
            _teacherRepository = teacherRepository;
            _disciplineRepository = disciplineRepository;

            comboBoxStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAssignmentDiscipline.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemester.DropDownStyle = ComboBoxStyle.DropDownList;

            numericUpDownGrade.Minimum = 2;
            numericUpDownGrade.Maximum = 5;
            numericUpDownGrade.Value = 3;

            dateTimePickerAssessmentDate.Format = DateTimePickerFormat.Short;
            checkedListBoxOptions.CheckOnClick = true;

            LoadStudents();
            LoadAssignmentDisciplines();
            LoadSemesters();
            LoadAssessmentOptions();

            buttonSave.Click -= buttonSave_Click;
            buttonSave.Click += buttonSave_Click;

            buttonCancel.Click -= buttonCancel_Click;
            buttonCancel.Click += buttonCancel_Click;

            CheckRequiredData();
        }

        private void LoadStudents()
        {
            comboBoxStudent.Items.Clear();

            foreach (var student in _studentRepository.ReadAll())
            {
                string fullName =
                    $"{student.LastName} {student.FirstName} {student.MiddleName}";

                comboBoxStudent.Items.Add(
                    new StudentComboBoxItem(student.Id, fullName, student.GroupName));
            }

            if (comboBoxStudent.Items.Count > 0)
                comboBoxStudent.SelectedIndex = 0;
        }

        private void LoadAssignmentDisciplines()
        {
            comboBoxAssignmentDiscipline.Items.Clear();

            var assignments = _assignmentRepository.ReadAll().ToList();
            var teachers = _teacherRepository.ReadAll().ToList();
            var disciplines = _disciplineRepository.ReadAll().ToList();

            foreach (var assignmentDiscipline in
                     _assignmentDisciplineRepository.ReadAll())
            {
                var assignment = assignments.FirstOrDefault(
                    x => x.Id == assignmentDiscipline.TeachingAssignmentId);

                if (assignment == null)
                    continue;

                var teacher = teachers.FirstOrDefault(
                    x => x.Id == assignment.TeacherId);

                var discipline = disciplines.FirstOrDefault(
                    x => x.Id == assignmentDiscipline.DisciplineId);

                // Не добавляем назначение, если отсутствует преподаватель
                // или дисциплина.
                if (teacher == null || discipline == null)
                    continue;

                string teacherName =
                    $"{teacher.LastName} {teacher.FirstName} {teacher.MiddleName}";

                string displayName =
                    $"{discipline.Name} — {teacherName}";

                comboBoxAssignmentDiscipline.Items.Add(
                    new AssignmentDisciplineComboBoxItem(
                        assignmentDiscipline.Id,
                        displayName));
            }

            if (comboBoxAssignmentDiscipline.Items.Count > 0)
                comboBoxAssignmentDiscipline.SelectedIndex = 0;
        }

        private void LoadSemesters()
        {
            comboBoxSemester.Items.Clear();
            comboBoxSemester.Items.Add("1");
            comboBoxSemester.Items.Add("2");
            comboBoxSemester.SelectedIndex = 0;
        }

        private void LoadAssessmentOptions()
        {
            checkedListBoxOptions.Items.Clear();

            checkedListBoxOptions.Items.Add(
                new AssessmentOptionItem(AssessmentOptions.Exam, "Экзамен"));

            checkedListBoxOptions.Items.Add(
                new AssessmentOptionItem(AssessmentOptions.Credit, "Зачёт"));

            checkedListBoxOptions.Items.Add(
                new AssessmentOptionItem(
                    AssessmentOptions.DifferentiatedCredit,
                    "Дифференцированный зачёт"));

            checkedListBoxOptions.Items.Add(
                new AssessmentOptionItem(
                    AssessmentOptions.Coursework,
                    "Курсовая работа"));

            checkedListBoxOptions.Items.Add(
                new AssessmentOptionItem(
                    AssessmentOptions.PracticalWork,
                    "Практическая работа"));
        }

        private AssessmentOptions GetSelectedOptions()
        {
            AssessmentOptions result = AssessmentOptions.None;

            foreach (var item in checkedListBoxOptions.CheckedItems)
            {
                if (item is AssessmentOptionItem optionItem)
                    result |= optionItem.Option;
            }

            return result;
        }

        private bool CheckRequiredData()
        {
            bool hasStudents = _studentRepository.ReadAll().Any();
            bool hasTeachers = _teacherRepository.ReadAll().Any();
            bool hasDisciplines = _disciplineRepository.ReadAll().Any();

            bool hasValidAssignment =
                comboBoxAssignmentDiscipline.Items.Count > 0;

            bool canSave =
                hasStudents &&
                hasTeachers &&
                hasDisciplines &&
                hasValidAssignment;

            buttonSave.Enabled = canSave;

            if (!canSave)
            {
                string message = "Невозможно добавить оценку.\n\n";

                if (!hasStudents)
                    message += "Сначала добавьте студента, преподавателя, дисциплину, назначьте преподавателя на дисциплину.\n";

                MessageBox.Show(
                    message,
                    "Недостаточно данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            return canSave;
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            if (!CheckRequiredData())
                return;

            if (comboBoxStudent.SelectedItem is not StudentComboBoxItem student)
            {
                MessageBox.Show("Выберите студента.");
                return;
            }

            if (comboBoxAssignmentDiscipline.SelectedItem
                is not AssignmentDisciplineComboBoxItem assignmentDiscipline)
            {
                MessageBox.Show("Выберите дисциплину и преподавателя.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAcademicYear.Text))
            {
                MessageBox.Show("Укажите учебный год.");
                textBoxAcademicYear.Focus();
                return;
            }

            if (comboBoxSemester.SelectedItem == null)
            {
                MessageBox.Show("Выберите семестр.");
                return;
            }

            int semester = int.Parse(comboBoxSemester.SelectedItem.ToString()!);

            AssessmentOptions options = GetSelectedOptions();

            if (options == AssessmentOptions.None)
            {
                MessageBox.Show("Выберите хотя бы один вид контроля.");
                return;
            }

            Performance = AcademicPerformance.CreateEntity(
                NewId,
                student.Id,
                assignmentDiscipline.Id,
                textBoxAcademicYear.Text.Trim(),
                semester,
                (int)numericUpDownGrade.Value,
                options,
                dateTimePickerAssessmentDate.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private class StudentComboBoxItem
        {
            public int Id { get; }
            public string FullName { get; }
            public string GroupName { get; }

            public StudentComboBoxItem(int id, string fullName, string groupName)
            {
                Id = id;
                FullName = fullName;
                GroupName = groupName;
            }

            public override string ToString()
            {
                return $"{FullName} — группа {GroupName}";
            }
        }

        private class AssignmentDisciplineComboBoxItem
        {
            public int Id { get; }
            public string DisplayName { get; }

            public AssignmentDisciplineComboBoxItem(
                int id,
                string displayName)
            {
                Id = id;
                DisplayName = displayName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        private class AssessmentOptionItem
        {
            public AssessmentOptions Option { get; }
            public string Name { get; }

            public AssessmentOptionItem(
                AssessmentOptions option,
                string name)
            {
                Option = option;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
