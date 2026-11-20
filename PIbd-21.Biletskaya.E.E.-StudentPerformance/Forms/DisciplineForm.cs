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
    public partial class DisciplineForm : Form
    {
        private readonly IDisciplineRepository _disciplineRepository;

        public DisciplineForm(IDisciplineRepository disciplineRepository)
        {
            InitializeComponent();

            _disciplineRepository = disciplineRepository;

            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            LoadDisciplines();
        }

        private void LoadDisciplines()
        {
            dataGridViewDisciplines.DataSource = null;

            dataGridViewDisciplines.DataSource =
                _disciplineRepository.ReadAll()
                    .Select(discipline => new
                    {
                        discipline.Id,
                        discipline.Name,
                        discipline.Hours,
                        discipline.Credits
                    })
                    .ToList();

            if (dataGridViewDisciplines.Columns.Count > 0)
            {
                dataGridViewDisciplines.Columns[nameof(Discipline.Id)].HeaderText = "ID";
                dataGridViewDisciplines.Columns[nameof(Discipline.Name)].HeaderText =
                    "Название дисциплины";
                dataGridViewDisciplines.Columns[nameof(Discipline.Hours)].HeaderText =
                    "Количество часов";
                dataGridViewDisciplines.Columns[nameof(Discipline.Credits)].HeaderText =
                    "Зачётные единицы";
            }
        }

        private Discipline? GetSelectedDiscipline()
        {
            if (dataGridViewDisciplines.CurrentRow == null)
                return null;

            int id = Convert.ToInt32(
                dataGridViewDisciplines.CurrentRow.Cells[nameof(Discipline.Id)].Value);

            return _disciplineRepository.ReadById(id);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            using DisciplineEditForm editForm = new DisciplineEditForm();

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Discipline != null)
            {
                int id = _disciplineRepository.ReadAll()
                    .Select(item => item.Id)
                    .DefaultIfEmpty(0)
                    .Max() + 1;

                Discipline discipline = Discipline.CreateEntity(
                    id,
                    editForm.Discipline.Name,
                    editForm.Discipline.Hours,
                    editForm.Discipline.Credits);

                _disciplineRepository.Create(discipline);

                LoadDisciplines();
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            Discipline? discipline = GetSelectedDiscipline();

            if (discipline == null)
            {
                MessageBox.Show("Выберите дисциплину для изменения.");
                return;
            }

            using DisciplineEditForm editForm =
                new DisciplineEditForm(discipline);

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Discipline != null)
            {
                _disciplineRepository.Update(editForm.Discipline);
                LoadDisciplines();
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            Discipline? discipline = GetSelectedDiscipline();

            if (discipline == null)
            {
                MessageBox.Show("Выберите дисциплину для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Удалить дисциплину «{discipline.Name}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _disciplineRepository.Delete(discipline.Id);
                LoadDisciplines();
            }
        }

        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            LoadDisciplines();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
