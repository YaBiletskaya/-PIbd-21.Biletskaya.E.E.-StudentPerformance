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
    public partial class TeachingAssignmentEditForm : Form
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public TeachingAssignment? Assignment { get; private set; }

        public TeachingAssignmentEditForm(
            ITeacherRepository teacherRepository,
            IDepartmentRepository departmentRepository)
        {
            InitializeComponent();

            _teacherRepository = teacherRepository;
            _departmentRepository = departmentRepository;

            LoadTeachers();
            LoadDepartments();

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += buttonCancel_Click;
        }

        private void LoadTeachers()
        {
            var teachers = _teacherRepository.ReadAll()
                .Select(teacher => new
                {
                    teacher.Id,
                    FullName = $"{teacher.LastName} {teacher.FirstName} {teacher.MiddleName}".Trim()
                })
                .ToList();

            comboBoxTeacher.DataSource = teachers;
            comboBoxTeacher.DisplayMember = "FullName";
            comboBoxTeacher.ValueMember = "Id";
        }

        private void LoadDepartments()
        {
            comboBoxDepartment.DataSource =
                _departmentRepository.ReadAll().ToList();

            comboBoxDepartment.DisplayMember = nameof(Department.Name);
            comboBoxDepartment.ValueMember = nameof(Department.Id);
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            if (comboBoxTeacher.SelectedValue == null)
            {
                MessageBox.Show("Выберите преподавателя.");
                return;
            }

            if (comboBoxDepartment.SelectedValue == null)
            {
                MessageBox.Show("Выберите кафедру.");
                return;
            }

            Assignment = TeachingAssignment.CreateEntity(
                0,
                Convert.ToInt32(comboBoxTeacher.SelectedValue),
                Convert.ToInt32(comboBoxDepartment.SelectedValue),
                dateTimePickerAssignmentDate.Value);

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
