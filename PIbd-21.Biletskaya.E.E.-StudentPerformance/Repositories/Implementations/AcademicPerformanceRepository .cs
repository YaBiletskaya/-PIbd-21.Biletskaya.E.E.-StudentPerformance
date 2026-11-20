using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class AcademicPerformanceRepository : IAcademicPerformanceRepository
{
    private readonly List<AcademicPerformance> _performances = new();

    public IEnumerable<AcademicPerformance> ReadAll()
    {
        return _performances;
    }

    public AcademicPerformance? ReadById(int id)
    {
        return _performances.FirstOrDefault(performance => performance.Id == id);
    }

    public void Create(AcademicPerformance entity)
    {
        _performances.Add(entity);
    }

    public void Delete(int id)
    {
        var entity = _performances.FirstOrDefault(x => x.Id == id);

        if (entity != null)
            _performances.Remove(entity);
    }
}
