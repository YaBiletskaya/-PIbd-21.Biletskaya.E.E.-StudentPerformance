using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

public class TeachingAssignment
{
    public int Id { get; private set; }

    public int TeacherId { get; private set; }

    public int DepartmentId { get; private set; }

    public DateTime AssignmentDate { get; private set; }

    private TeachingAssignment()
    {
    }

    public static TeachingAssignment CreateEntity(
        int id,
        int teacherId,
        int departmentId,
        DateTime assignmentDate)
    {
        return new TeachingAssignment
        {
            Id = id,
            TeacherId = teacherId,
            DepartmentId = departmentId,
            AssignmentDate = assignmentDate
        };
    }
}
