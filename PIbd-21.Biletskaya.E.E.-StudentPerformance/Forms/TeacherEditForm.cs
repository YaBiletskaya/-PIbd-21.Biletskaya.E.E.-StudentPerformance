using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities.Enums;
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
    public partial class TeacherEditForm : Form
    {
        public Teacher? Teacher { get; private set; }

        public TeacherEditForm()
        {
            InitializeComponent();

            comboBoxPosition.DataSource = Enum.GetValues<TeacherPosition>();

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += buttonCancel_Click;
        }

        public TeacherEditForm(Teacher teacher) : this()
        {
            Teacher = teacher;

            textBoxFirstName.Text = teacher.FirstName;
            textBoxLastName.Text = teacher.LastName;
            textBoxMiddleName.Text = teacher.MiddleName;
            textBoxAcademicDegree.Text = teacher.AcademicDegree;
            comboBoxPosition.SelectedItem = teacher.Position;
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show(
                    "Введите имя и фамилию преподавателя.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (comboBoxPosition.SelectedItem == null)
            {
                MessageBox.Show("Выберите должность преподавателя.");
                return;
            }

            Teacher = Teacher.CreateEntity(
                Teacher?.Id ?? 0,
                textBoxFirstName.Text.Trim(),
                textBoxLastName.Text.Trim(),
                textBoxMiddleName.Text.Trim(),
                textBoxAcademicDegree.Text.Trim(),
                (TeacherPosition)comboBoxPosition.SelectedItem);

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
