using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
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
    public partial class FacultyEditForm : Form
    {
        public Faculty? Faculty { get; private set; }

        public FacultyEditForm()
        {
            InitializeComponent();

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += buttonCancel_Click;
        }

        public FacultyEditForm(Faculty faculty) : this()
        {
            Faculty = faculty;

            textBoxName.Text = faculty.Name;
            textBoxDean.Text = faculty.DeanFullName;
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show(
                    "Введите название факультета.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxName.Focus();
                return;
            }

            Faculty = Faculty.CreateEntity(
                Faculty?.Id ?? 0,
                textBoxName.Text.Trim(),
                textBoxDean.Text.Trim());

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
