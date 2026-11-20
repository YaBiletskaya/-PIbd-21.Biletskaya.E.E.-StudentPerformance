using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

public class Student
{
    public int Id { get; private set; }

    public int DepartmentId { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public string MiddleName { get; private set; } = string.Empty;

    public string StudentNumber { get; private set; } = string.Empty;

    public DateTime BirthDate { get; private set; }

    public string StreamName { get; private set; } = string.Empty;

    public string GroupName { get; private set; } = string.Empty;

    public int AdmissionYear { get; private set; }

    private Student()
    {
    }

    public static Student CreateEntity(
        int id,
        int departmentId,
        string? firstName,
        string? lastName,
        string? middleName,
        string? studentNumber,
        DateTime birthDate,
        string? streamName,
        string? groupName,
        int admissionYear)
    {
        return new Student
        {
            Id = id,
            DepartmentId = departmentId,
            FirstName = firstName ?? string.Empty,
            LastName = lastName ?? string.Empty,
            MiddleName = middleName ?? string.Empty,
            StudentNumber = studentNumber ?? string.Empty,
            BirthDate = birthDate,
            StreamName = streamName ?? string.Empty,
            GroupName = groupName ?? string.Empty,
            AdmissionYear = admissionYear
        };
    }
}
