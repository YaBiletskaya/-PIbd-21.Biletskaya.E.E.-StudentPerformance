using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class TeacherRepository : ITeacherRepository
{
    private readonly List<Teacher> _teachers = new();

    public IEnumerable<Teacher> ReadAll()
    {
        return _teachers;
    }

    public Teacher? ReadById(int id)
    {
        return _teachers.FirstOrDefault(teacher => teacher.Id == id);
    }

    public void Create(Teacher entity)
    {
        _teachers.Add(entity);
    }

    public void Update(Teacher entity)
    {
        var teacher = ReadById(entity.Id);

        if (teacher != null)
        {
            _teachers.Remove(teacher);
            _teachers.Add(entity);
        }
    }

    public void Delete(int id)
    {
        var teacher = ReadById(id);

        if (teacher != null)
        {
            _teachers.Remove(teacher);
        }
    }
}
