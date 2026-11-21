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
    public partial class FacultyForm : Form
    {
        private readonly IFacultyRepository _facultyRepository;

        public FacultyForm(IFacultyRepository facultyRepository)
        {
            InitializeComponent();

            _facultyRepository = facultyRepository;

            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            LoadFaculties();
        }

        private void LoadFaculties()
        {
            dataGridViewFaculties.DataSource = null;
            dataGridViewFaculties.DataSource = _facultyRepository.ReadAll()
                .Select(faculty => new
                {
                    faculty.Id,
                    faculty.Name,
                    faculty.DeanFullName
                })
                .ToList();

            dataGridViewFaculties.Columns[nameof(Faculty.Name)].HeaderText =
                "Название факультета";

            dataGridViewFaculties.Columns[nameof(Faculty.DeanFullName)].HeaderText =
                "ФИО декана";
        }

        private Faculty? GetSelectedFaculty()
        {
            if (dataGridViewFaculties.CurrentRow == null)
            {
                return null;
            }

            int id = Convert.ToInt32(
                dataGridViewFaculties.CurrentRow.Cells[nameof(Faculty.Id)].Value);

            return _facultyRepository.ReadById(id);
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            using FacultyEditForm editForm = new FacultyEditForm();

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Faculty != null)
            {
                Faculty faculty = Faculty.CreateEntity(
                    _facultyRepository.ReadAll()
                        .Select(item => item.Id)
                        .DefaultIfEmpty(0)
                        .Max() + 1,
                    editForm.Faculty.Name,
                    editForm.Faculty.DeanFullName);

                _facultyRepository.Create(faculty);
                LoadFaculties();
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            Faculty? faculty = GetSelectedFaculty();

            if (faculty == null)
            {
                MessageBox.Show("Выберите факультет для изменения.");
                return;
            }

            using FacultyEditForm editForm = new FacultyEditForm(faculty);

            if (editForm.ShowDialog(this) == DialogResult.OK &&
                editForm.Faculty != null)
            {
                _facultyRepository.Update(editForm.Faculty);
                LoadFaculties();
            }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            Faculty? faculty = GetSelectedFaculty();

            if (faculty == null)
            {
                MessageBox.Show("Выберите факультет для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Удалить факультет «{faculty.Name}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _facultyRepository.Delete(faculty.Id);
                LoadFaculties();
            }
        }

        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            LoadFaculties();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
