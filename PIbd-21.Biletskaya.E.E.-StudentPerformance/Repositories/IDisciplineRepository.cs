using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;

public interface IDisciplineRepository
{
    IEnumerable<Discipline> ReadAll();
    Discipline? ReadById(int id);
    void Create(Discipline entity);
    void Update(Discipline entity);
    void Delete(int id);
}
