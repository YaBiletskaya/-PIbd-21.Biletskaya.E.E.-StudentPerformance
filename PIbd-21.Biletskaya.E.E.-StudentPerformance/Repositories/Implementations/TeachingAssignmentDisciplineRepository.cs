using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class TeachingAssignmentDisciplineRepository : ITeachingAssignmentDisciplineRepository
{
    private readonly List<TeachingAssignmentDiscipline> _items = new();

    public IEnumerable<TeachingAssignmentDiscipline> ReadAll()
    {
        return _items;
    }

    public TeachingAssignmentDiscipline? ReadById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }

    public void Create(TeachingAssignmentDiscipline entity)
    {
        _items.Add(entity);
    }

    public void Delete(int id)
    {
        TeachingAssignmentDiscipline? entity = ReadById(id);

        if (entity != null)
        {
            _items.Remove(entity);
        }
    }
}
