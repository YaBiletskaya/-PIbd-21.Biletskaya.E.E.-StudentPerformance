using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;

public interface IFacultyRepository
{
    IEnumerable<Faculty> ReadAll();
    Faculty? ReadById(int id);
    void Create(Faculty entity);
    void Update(Faculty entity);
    void Delete(int id);
}
