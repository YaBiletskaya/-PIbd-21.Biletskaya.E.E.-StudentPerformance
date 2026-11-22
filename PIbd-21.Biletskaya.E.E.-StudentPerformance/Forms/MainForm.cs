using PIbd_21.Biletskaya.E.E._StudentPerformance.DependencyInjection;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Forms;
using Microsoft.Extensions.Logging;
using Unity;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly ILogger _logger;

        public MainForm(
            IUnityContainer container,
            ILogger logger)
        {
            InitializeComponent();

            _container = container;
            _logger = logger;

            _logger.LogInformation("Открыта главная форма приложения");
        }

        private void OpenForm<TForm>(string formName)
            where TForm : Form
        {
            try
            {
                _logger.LogInformation(
                    "Открытие раздела: {FormName}", formName);

                using TForm form = _container.Resolve<TForm>();
                form.ShowDialog(this);

                _logger.LogInformation(
                    "Закрыт раздел: {FormName}", formName);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Ошибка при открытии раздела: {FormName}",
                    formName);

                MessageBox.Show(
                    "Не удалось открыть раздел.\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void факультетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FacultyForm>("Факультеты");
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<DepartmentForm>("Кафедры");
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<TeacherForm>("Преподаватели");
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<DisciplineForm>("Дисциплины");
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<StudentForm>("Студенты");
        }

        private void назначенияПреподавателейToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            OpenForm<TeachingAssignmentForm>("Назначения преподавателей");
        }

        private void дисциплиныПреподавателейtoolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            OpenForm<TeachingAssignmentDisciplineForm>(
                "Дисциплины преподавателей");
        }

        private void успеваемостьСтудентовToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            OpenForm<AcademicPerformanceForm>("Успеваемость студентов");
        }
    }
}
