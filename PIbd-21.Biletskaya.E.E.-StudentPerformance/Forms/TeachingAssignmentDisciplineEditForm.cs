using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
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
    public partial class TeachingAssignmentDisciplineEditForm : Form
    {
        private readonly ITeachingAssignmentRepository _assignmentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IDisciplineRepository _disciplineRepository;

        public TeachingAssignmentDiscipline? AssignmentDiscipline { get; private set; }

        public TeachingAssignmentDisciplineEditForm(
            ITeachingAssignmentRepository assignmentRepository,
            ITeacherRepository teacherRepository,
            IDepartmentRepository departmentRepository,
            IDisciplineRepository disciplineRepository)
        {
            InitializeComponent();

            _assignmentRepository = assignmentRepository;
            _teacherRepository = teacherRepository;
            _departmentRepository = departmentRepository;
            _disciplineRepository = disciplineRepository;

            LoadAssignments();
            LoadDisciplines();

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += buttonCancel_Click;
        }

        private void LoadAssignments()
        {
            var assignments = _assignmentRepository.ReadAll()
                .Select(assignment =>
                {
                    Teacher? teacher = _teacherRepository.ReadById(assignment.TeacherId);
                    Department? department =
                        _departmentRepository.ReadById(assignment.DepartmentId);

                    return new
                    {
                        assignment.Id,
                        DisplayName =
                            $"{teacher?.LastName} {teacher?.FirstName} — " +
                            $"{department?.Name} ({assignment.AssignmentDate:dd.MM.yyyy})"
                    };
                })
                .ToList();

            comboBoxAssignment.DataSource = assignments;
            comboBoxAssignment.DisplayMember = "DisplayName";
            comboBoxAssignment.ValueMember = "Id";
        }

        private void LoadDisciplines()
        {
            comboBoxDiscipline.DataSource =
                _disciplineRepository.ReadAll().ToList();

            comboBoxDiscipline.DisplayMember = nameof(Discipline.Name);
            comboBoxDiscipline.ValueMember = nameof(Discipline.Id);
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            if (comboBoxAssignment.SelectedValue == null)
            {
                MessageBox.Show("Выберите назначение преподавателя.");
                return;
            }

            if (comboBoxDiscipline.SelectedValue == null)
            {
                MessageBox.Show("Выберите дисциплину.");
                return;
            }

            AssignmentDiscipline = TeachingAssignmentDiscipline.CreateEntity(
                0,
                Convert.ToInt32(comboBoxAssignment.SelectedValue),
                Convert.ToInt32(comboBoxDiscipline.SelectedValue),
                (int)numericUpDownHours.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
