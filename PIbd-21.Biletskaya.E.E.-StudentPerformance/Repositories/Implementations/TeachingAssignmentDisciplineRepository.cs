using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class TeachingAssignmentDisciplineRepository : ITeachingAssignmentDisciplineRepository
{
    private readonly DataContext _context;

    public TeachingAssignmentDisciplineRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<TeachingAssignmentDiscipline> ReadAll()
    {
        return _context.TeachingAssignmentDisciplines.ToList();
    }

    public TeachingAssignmentDiscipline? ReadById(int id)
    {
        return _context.TeachingAssignmentDisciplines
            .FirstOrDefault(x => x.Id == id);
    }

    public void Create(TeachingAssignmentDiscipline entity)
    {
        _context.TeachingAssignmentDisciplines.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.TeachingAssignmentDisciplines.Find(id);

        if (entity == null)
            return;

        _context.TeachingAssignmentDisciplines.Remove(entity);
        _context.SaveChanges();
    }
}
