using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

public class TeachingAssignmentDiscipline
{
    public int Id { get; private set; }

    public int TeachingAssignmentId { get; private set; }

    public int DisciplineId { get; private set; }

    public int Hours { get; private set; }

    private TeachingAssignmentDiscipline()
    {
    }

    public static TeachingAssignmentDiscipline CreateEntity(
        int id,
        int teachingAssignmentId,
        int disciplineId,
        int hours)
    {
        return new TeachingAssignmentDiscipline
        {
            Id = id,
            TeachingAssignmentId = teachingAssignmentId,
            DisciplineId = disciplineId,
            Hours = hours
        };
    }
}
