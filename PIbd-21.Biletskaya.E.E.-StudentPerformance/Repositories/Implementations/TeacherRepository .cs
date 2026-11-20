using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class TeacherRepository : ITeacherRepository
{
    private readonly DataContext _context;

    public TeacherRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Teacher> ReadAll()
    {
        return _context.Teachers.ToList();
    }

    public Teacher? ReadById(int id)
    {
        return _context.Teachers.FirstOrDefault(x => x.Id == id);
    }

    public void Create(Teacher entity)
    {
        _context.Teachers.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Teacher entity)
    {
        var existingEntity = _context.Teachers
            .FirstOrDefault(x => x.Id == entity.Id);

        if (existingEntity == null)
            return;

        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.Teachers.Find(id);

        if (entity == null)
            return;

        _context.Teachers.Remove(entity);
        _context.SaveChanges();
    }
}
