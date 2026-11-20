using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories;

public interface ITeacherRepository
{
    IEnumerable<Teacher> ReadAll();
    Teacher? ReadById(int id);
    void Create(Teacher entity);
    void Update(Teacher entity);
    void Delete(int id);
}
