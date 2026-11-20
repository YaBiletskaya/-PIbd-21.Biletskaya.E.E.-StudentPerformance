using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly DataContext _context;

    public DepartmentRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Department> ReadAll()
    {
        return _context.Departments.ToList();
    }

    public Department? ReadById(int id)
    {
        return _context.Departments.FirstOrDefault(x => x.Id == id);
    }

    public void Create(Department entity)
    {
        _context.Departments.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Department entity)
    {
        _context.Departments.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.Departments.Find(id);

        if (entity == null)
            return;

        _context.Departments.Remove(entity);
        _context.SaveChanges();
    }
}
