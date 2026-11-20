using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class DisciplineRepository : IDisciplineRepository
{
    private readonly DataContext _context;

    public DisciplineRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Discipline> ReadAll()
    {
        return _context.Disciplines.ToList();
    }

    public Discipline? ReadById(int id)
    {
        return _context.Disciplines.FirstOrDefault(x => x.Id == id);
    }

    public void Create(Discipline entity)
    {
        _context.Disciplines.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Discipline entity)
    {
        _context.Disciplines.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.Disciplines.Find(id);

        if (entity == null)
            return;

        _context.Disciplines.Remove(entity);
        _context.SaveChanges();
    }
}
