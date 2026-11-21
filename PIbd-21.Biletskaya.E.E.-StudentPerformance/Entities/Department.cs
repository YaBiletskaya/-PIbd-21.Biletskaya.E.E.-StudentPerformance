using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

public class Department
{
    public int Id { get; private set; }

    public int FacultyId { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string HeadFullName { get; private set; } = string.Empty;

    private Department()
    {
    }

    public static Department CreateEntity(
        int id,
        int facultyId,
        string? name,
        string? headFullName)
    {
        return new Department
        {
            Id = id,
            FacultyId = facultyId,
            Name = name ?? string.Empty,
            HeadFullName = headFullName ?? string.Empty
        };
    }
}
