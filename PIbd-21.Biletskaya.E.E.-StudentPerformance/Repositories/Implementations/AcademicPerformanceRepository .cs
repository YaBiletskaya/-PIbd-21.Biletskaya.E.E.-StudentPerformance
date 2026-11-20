using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class AcademicPerformanceRepository : IAcademicPerformanceRepository
{
    private readonly DataContext _context;

    public AcademicPerformanceRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<AcademicPerformance> ReadAll()
    {
        return _context.AcademicPerformances.ToList();
    }

    public AcademicPerformance? ReadById(int id)
    {
        return _context.AcademicPerformances
            .FirstOrDefault(x => x.Id == id);
    }

    public void Create(AcademicPerformance entity)
    {
        _context.AcademicPerformances.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.AcademicPerformances.Find(id);

        if (entity == null)
            return;

        _context.AcademicPerformances.Remove(entity);
        _context.SaveChanges();
    }
}
