using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities.Enums;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

public class AcademicPerformance
{
    public int Id { get; private set; }

    public int StudentId { get; private set; }

    public int TeachingAssignmentDisciplineId { get; private set; }

    public string AcademicYear { get; private set; } = string.Empty;

    public int Semester { get; private set; }

    public int Grade { get; private set; }

    public AssessmentOptions Options { get; private set; }

    public DateTime AssessmentDate { get; private set; }

    private AcademicPerformance()
    {
    }

    public static AcademicPerformance CreateEntity(
        int id,
        int studentId,
        int teachingAssignmentDisciplineId,
        string? academicYear,
        int semester,
        int grade,
        AssessmentOptions options,
        DateTime assessmentDate)
    {
        return new AcademicPerformance
        {
            Id = id,
            StudentId = studentId,
            TeachingAssignmentDisciplineId = teachingAssignmentDisciplineId,
            AcademicYear = academicYear ?? string.Empty,
            Semester = semester,
            Grade = grade,
            Options = options,
            AssessmentDate = assessmentDate
        };
    }
}
