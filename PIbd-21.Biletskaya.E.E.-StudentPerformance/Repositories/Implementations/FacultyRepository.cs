using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class FacultyRepository : IFacultyRepository
{
    private readonly List<Faculty> _faculties = new();

    public IEnumerable<Faculty> ReadAll()
    {
        return _faculties;
    }

    public Faculty? ReadById(int id)
    {
        return _faculties.FirstOrDefault(faculty => faculty.Id == id);
    }

    public void Create(Faculty entity)
    {
        _faculties.Add(entity);
    }

    public void Update(Faculty entity)
    {
        var faculty = ReadById(entity.Id);

        if (faculty != null)
        {
            _faculties.Remove(faculty);
            _faculties.Add(entity);
        }
    }

    public void Delete(int id)
    {
        var faculty = ReadById(id);

        if (faculty != null)
        {
            _faculties.Remove(faculty);
        }
    }
}
