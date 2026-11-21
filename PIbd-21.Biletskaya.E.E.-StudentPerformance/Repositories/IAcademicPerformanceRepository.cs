using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;

public interface IAcademicPerformanceRepository
{
    IEnumerable<AcademicPerformance> ReadAll();
    AcademicPerformance? ReadById(int id);
    void Create(AcademicPerformance entity);
    void Delete(int id);
}
