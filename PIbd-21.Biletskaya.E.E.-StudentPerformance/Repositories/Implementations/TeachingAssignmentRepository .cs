using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class TeachingAssignmentRepository : ITeachingAssignmentRepository
{
    private readonly List<TeachingAssignment> _assignments = new();

    public IEnumerable<TeachingAssignment> ReadAll()
    {
        return _assignments;
    }

    public TeachingAssignment? ReadById(int id)
    {
        return _assignments.FirstOrDefault(assignment => assignment.Id == id);
    }

    public void Create(TeachingAssignment entity)
    {
        _assignments.Add(entity);
    }

    public void Delete(int id)
    {
        var assignment = ReadById(id);

        if (assignment != null)
        {
            _assignments.Remove(assignment);
        }
    }
}
