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
    public partial class DisciplineEditForm : Form
    {
        public Discipline? Discipline { get; private set; }

        public DisciplineEditForm()
        {
            InitializeComponent();

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += buttonCancel_Click;
        }

        public DisciplineEditForm(Discipline discipline) : this()
        {
            Discipline = discipline;

            textBoxName.Text = discipline.Name;
            numericUpDownHours.Value = discipline.Hours;
            numericUpDownCredits.Value = discipline.Credits;
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show(
                    "Введите название дисциплины.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxName.Focus();
                return;
            }

            Discipline = Discipline.CreateEntity(
                Discipline?.Id ?? 0,
                textBoxName.Text.Trim(),
                (int)numericUpDownHours.Value,
                numericUpDownCredits.Value);

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
