using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class StudentRepository : IStudentRepository
{
    private readonly DataContext _context;

    public StudentRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Student> ReadAll()
    {
        return _context.Students.ToList();
    }

    public Student? ReadById(int id)
    {
        return _context.Students.FirstOrDefault(x => x.Id == id);
    }

    public void Create(Student entity)
    {
        _context.Students.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Student entity)
    {
        _context.Students.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.Students.Find(id);

        if (entity == null)
            return;

        _context.Students.Remove(entity);
        _context.SaveChanges();
    }
}
