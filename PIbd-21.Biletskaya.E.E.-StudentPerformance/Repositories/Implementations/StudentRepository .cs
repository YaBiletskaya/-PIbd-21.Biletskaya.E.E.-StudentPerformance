using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class StudentRepository : IStudentRepository
{
    private readonly List<Student> _students = new();

    public IEnumerable<Student> ReadAll()
    {
        return _students;
    }

    public Student? ReadById(int id)
    {
        return _students.FirstOrDefault(student => student.Id == id);
    }

    public void Create(Student entity)
    {
        _students.Add(entity);
    }

    public void Update(Student entity)
    {
        var student = ReadById(entity.Id);

        if (student != null)
        {
            _students.Remove(student);
            _students.Add(entity);
        }
    }

    public void Delete(int id)
    {
        var student = ReadById(id);

        if (student != null)
        {
            _students.Remove(student);
        }
    }
}
