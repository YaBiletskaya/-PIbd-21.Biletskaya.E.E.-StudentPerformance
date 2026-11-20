using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Forms;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;
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

        container.RegisterType<DataContext>();

        container.RegisterType<IFacultyRepository, FacultyRepository>();
        container.RegisterType<IDepartmentRepository, DepartmentRepository>();
        container.RegisterType<ITeacherRepository, TeacherRepository>();
        container.RegisterType<IDisciplineRepository, DisciplineRepository>();
        container.RegisterType<IStudentRepository, StudentRepository>();
        container.RegisterType<ITeachingAssignmentRepository, TeachingAssignmentRepository>();
        container.RegisterType<IAcademicPerformanceRepository, AcademicPerformanceRepository>();
        container.RegisterType<ITeachingAssignmentDisciplineRepository, TeachingAssignmentDisciplineRepository>();

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
