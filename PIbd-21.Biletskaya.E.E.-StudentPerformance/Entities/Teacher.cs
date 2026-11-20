using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities.Enums;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

public class Teacher
{
    public int Id { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public string MiddleName { get; private set; } = string.Empty;

    public string AcademicDegree { get; private set; } = string.Empty;

    public TeacherPosition Position { get; private set; }

    private Teacher()
    {
    }

    public static Teacher CreateEntity(
        int id,
        string? firstName,
        string? lastName,
        string? middleName,
        string? academicDegree,
        TeacherPosition position)
    {
        return new Teacher
        {
            Id = id,
            FirstName = firstName ?? string.Empty,
            LastName = lastName ?? string.Empty,
            MiddleName = middleName ?? string.Empty,
            AcademicDegree = academicDegree ?? string.Empty,
            Position = position
        };
    }
}
