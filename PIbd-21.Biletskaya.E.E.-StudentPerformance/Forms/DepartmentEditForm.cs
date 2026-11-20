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
    public partial class DepartmentEditForm : Form
    {
        private readonly IFacultyRepository _facultyRepository;

        public Department? Department { get; private set; }

        public DepartmentEditForm(IFacultyRepository facultyRepository)
        {
            InitializeComponent();

            _facultyRepository = facultyRepository;

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += buttonCancel_Click;

            LoadFaculties();
        }

        public DepartmentEditForm(
            IFacultyRepository facultyRepository,
            Department department) : this(facultyRepository)
        {
            Department = department;

            textBoxName.Text = department.Name;
            textBoxHead.Text = department.HeadFullName;

            comboBoxFaculty.SelectedValue = department.FacultyId;
        }

        private void LoadFaculties()
        {
            var faculties = _facultyRepository.ReadAll().ToList();

            comboBoxFaculty.DataSource = faculties;
            comboBoxFaculty.DisplayMember = nameof(Faculty.Name);
            comboBoxFaculty.ValueMember = nameof(Faculty.Id);
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            if (comboBoxFaculty.SelectedValue == null)
            {
                MessageBox.Show("Выберите факультет.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите название кафедры.");
                textBoxName.Focus();
                return;
            }

            Department = Department.CreateEntity(
                Department?.Id ?? 0,
                Convert.ToInt32(comboBoxFaculty.SelectedValue),
                textBoxName.Text.Trim(),
                textBoxHead.Text.Trim());

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
