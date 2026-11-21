using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.DependencyInjection;

public class DependencyConfig
{
    public static IUnityContainer CreateContainer()
    {
        IUnityContainer container = new UnityContainer();

        container.RegisterSingleton<IFacultyRepository, FacultyRepository>();
        container.RegisterSingleton<IDepartmentRepository, DepartmentRepository>();
        container.RegisterSingleton<ITeacherRepository, TeacherRepository>();
        container.RegisterSingleton<IDisciplineRepository, DisciplineRepository>();
        container.RegisterSingleton<IStudentRepository, StudentRepository>();
        container.RegisterSingleton<ITeachingAssignmentRepository, TeachingAssignmentRepository>();
        container.RegisterSingleton<IAcademicPerformanceRepository, AcademicPerformanceRepository>();
        container.RegisterSingleton<ITeachingAssignmentDisciplineRepository, TeachingAssignmentDisciplineRepository>();

        container.RegisterType<FacultyForm>();
        container.RegisterType<FacultyEditForm>();
        container.RegisterType<DepartmentForm>();
        container.RegisterType<DepartmentEditForm>();
        container.RegisterType<MainForm>();
        container.RegisterType<TeacherForm>();
        container.RegisterType<TeacherEditForm>();
        container.RegisterType<DisciplineForm>();
        container.RegisterType<DisciplineEditForm>();
        container.RegisterType<StudentForm>();
        container.RegisterType<StudentEditForm>();
        container.RegisterType<TeachingAssignmentForm>();
        container.RegisterType<TeachingAssignmentEditForm>();
        container.RegisterType<TeachingAssignmentDisciplineForm>();
        container.RegisterType<TeachingAssignmentDisciplineEditForm>();
        container.RegisterType<AcademicPerformanceForm>();
        container.RegisterType<AcademicPerformanceEditForm>();

        return container;
    }
}
