using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
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
    private readonly DataContext _context;

    public TeachingAssignmentRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<TeachingAssignment> ReadAll()
    {
        return _context.TeachingAssignments.ToList();
    }

    public TeachingAssignment? ReadById(int id)
    {
        return _context.TeachingAssignments
            .FirstOrDefault(x => x.Id == id);
    }

    public void Create(TeachingAssignment entity)
    {
        _context.TeachingAssignments.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.TeachingAssignments.Find(id);

        if (entity == null)
            return;

        _context.TeachingAssignments.Remove(entity);
        _context.SaveChanges();
    }
}
