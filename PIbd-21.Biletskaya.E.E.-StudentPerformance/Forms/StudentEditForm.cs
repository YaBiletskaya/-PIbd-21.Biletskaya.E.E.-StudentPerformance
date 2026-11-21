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
    public partial class StudentEditForm : Form
    {
        private readonly IDepartmentRepository _departmentRepository;

        public Student? Student { get; private set; }

        public StudentEditForm(IDepartmentRepository departmentRepository)
        {
            InitializeComponent();

            _departmentRepository = departmentRepository;

            LoadDepartments();

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += buttonCancel_Click;
        }

        public StudentEditForm(
            IDepartmentRepository departmentRepository,
            Student student) : this(departmentRepository)
        {
            Student = student;

            comboBoxDepartment.SelectedValue = student.DepartmentId;

            textBoxFirstName.Text = student.FirstName;
            textBoxLastName.Text = student.LastName;
            textBoxMiddleName.Text = student.MiddleName;
            textBoxStudentNumber.Text = student.StudentNumber;
            dateTimePickerBirthDate.Value = student.BirthDate;
            textBoxStreamName.Text = student.StreamName;
            textBoxGroupName.Text = student.GroupName;
            numericUpDownAdmissionYear.Value = student.AdmissionYear;
        }

        private void LoadDepartments()
        {
            var departments = _departmentRepository.ReadAll().ToList();

            comboBoxDepartment.DataSource = departments;
            comboBoxDepartment.DisplayMember = nameof(Department.Name);
            comboBoxDepartment.ValueMember = nameof(Department.Id);
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            if (comboBoxDepartment.SelectedValue == null)
            {
                MessageBox.Show("Выберите кафедру.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show(
                    "Введите имя и фамилию студента.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxStudentNumber.Text))
            {
                MessageBox.Show("Введите номер студенческого билета.");
                textBoxStudentNumber.Focus();
                return;
            }

            if (dateTimePickerBirthDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Дата рождения не может быть в будущем.");
                return;
            }

            Student = Student.CreateEntity(
                Student?.Id ?? 0,
                Convert.ToInt32(comboBoxDepartment.SelectedValue),
                textBoxFirstName.Text.Trim(),
                textBoxLastName.Text.Trim(),
                textBoxMiddleName.Text.Trim(),
                textBoxStudentNumber.Text.Trim(),
                dateTimePickerBirthDate.Value.Date,
                textBoxStreamName.Text.Trim(),
                textBoxGroupName.Text.Trim(),
                (int)numericUpDownAdmissionYear.Value);

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
