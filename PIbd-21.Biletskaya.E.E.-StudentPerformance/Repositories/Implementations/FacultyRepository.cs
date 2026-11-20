using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class FacultyRepository : IFacultyRepository
{
    private readonly DataContext _context;

    public FacultyRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Faculty> ReadAll()
    {
        return _context.Faculties.ToList();
    }

    public Faculty? ReadById(int id)
    {
        return _context.Faculties
            .FirstOrDefault(x => x.Id == id);
    }

    public void Create(Faculty entity)
    {
        _context.Faculties.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Faculty entity)
    {
        _context.Faculties.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var faculty = _context.Faculties.Find(id);

        if (faculty == null)
            return;

        _context.Faculties.Remove(faculty);
        _context.SaveChanges();
    }
}
