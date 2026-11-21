using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;

public interface IDepartmentRepository
{
    IEnumerable<Department> ReadAll();
    Department? ReadById(int id);
    void Create(Department entity);
    void Update(Department entity);
    void Delete(int id);
}
