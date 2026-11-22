using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;
using Serilog.Core;
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
        private readonly ILogger _logger;

        public DisciplineForm(IDisciplineRepository disciplineRepository, ILogger logger)
        {
            InitializeComponent();

            _disciplineRepository = disciplineRepository;
            _logger = logger;
            _logger.LogInformation("Открыта форма управления дисциплинами");

            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonClose.Click += buttonClose_Click;

            LoadDisciplines();
        }

        private void LoadDisciplines()
        {
            _logger.LogInformation("Загрузка списка дисциплин");

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
            _logger.LogInformation("Пользователь начал добавление дисциплины");

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
                _logger.LogInformation(
                "Добавлена дисциплина. ID: {DisciplineId}, название: {DisciplineName}",
                discipline.Id,
                discipline.Name);

                LoadDisciplines();
            }
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал изменение дисциплины");

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
                _logger.LogInformation(
                "Изменена дисциплина. ID: {DisciplineId}, название: {DisciplineName}",
                editForm.Discipline.Id,
                editForm.Discipline.Name);
                LoadDisciplines();
            }
        }


        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Пользователь начал удаление дисциплины");

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

            if (result != DialogResult.Yes)
                return;

            try
            {
                _disciplineRepository.Delete(discipline.Id);

                _logger.LogInformation(
                    "Удалена дисциплина. ID: {DisciplineId}, название: {DisciplineName}",
                    discipline.Id,
                    discipline.Name);

                MessageBox.Show(
                    "Дисциплина успешно удалена.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDisciplines();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogWarning(
                    ex,
                    "Невозможно удалить дисциплину. ID: {DisciplineId}: существуют связанные записи",
                    discipline.Id);

                MessageBox.Show(
                    "Невозможно удалить дисциплину, так как она закреплена за учебными назначениями или по ней выставлены оценки.",
                    "Удаление невозможно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка при удалении дисциплины. ID: {DisciplineId}",
                    discipline.Id);

                MessageBox.Show(
                    "Произошла ошибка при удалении дисциплины.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void buttonRefresh_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Обновление списка дисциплин"); 
            LoadDisciplines();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            _logger.LogInformation("Закрыта форма управления дисциплинами"); 
            Close();
        }
    }
}
