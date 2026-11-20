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
    private readonly List<Department> _departments = new();

    public IEnumerable<Department> ReadAll()
    {
        return _departments;
    }

    public Department? ReadById(int id)
    {
        return _departments.FirstOrDefault(department => department.Id == id);
    }

    public void Create(Department entity)
    {
        _departments.Add(entity);
    }

    public void Update(Department entity)
    {
        var department = ReadById(entity.Id);

        if (department != null)
        {
            _departments.Remove(department);
            _departments.Add(entity);
        }
    }

    public void Delete(int id)
    {
        var department = ReadById(id);

        if (department != null)
        {
            _departments.Remove(department);
        }
    }
}
