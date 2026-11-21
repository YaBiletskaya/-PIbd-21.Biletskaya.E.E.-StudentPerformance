using PIbd_21.Biletskaya.E.E._StudentPerformance.DependencyInjection;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Forms;
using Unity;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();

            _container = container;
        }

        private void факультетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FacultyForm form = _container.Resolve<FacultyForm>();
            form.ShowDialog(this);
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using DepartmentForm form = _container.Resolve<DepartmentForm>();
            form.ShowDialog(this);
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using TeacherForm form = _container.Resolve<TeacherForm>();
            form.ShowDialog(this);
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using DisciplineForm form = _container.Resolve<DisciplineForm>();
            form.ShowDialog(this);
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using StudentForm form = _container.Resolve<StudentForm>();
            form.ShowDialog(this);
        }

        private void назначенияПреподавателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using TeachingAssignmentForm form =
            _container.Resolve<TeachingAssignmentForm>();

            form.ShowDialog(this);
        }

        private void дисциплиныПреподавателейtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            using TeachingAssignmentDisciplineForm form =
            _container.Resolve<TeachingAssignmentDisciplineForm>();

            form.ShowDialog(this);
        }

        private void успеваемостьСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = _container.Resolve<AcademicPerformanceForm>();
            form.ShowDialog(this);
        }
    }
}
