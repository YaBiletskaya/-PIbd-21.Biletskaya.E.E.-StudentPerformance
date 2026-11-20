using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class DisciplineRepository : IDisciplineRepository
{
    private readonly List<Discipline> _disciplines = new();

    public IEnumerable<Discipline> ReadAll()
    {
        return _disciplines;
    }

    public Discipline? ReadById(int id)
    {
        return _disciplines.FirstOrDefault(discipline => discipline.Id == id);
    }

    public void Create(Discipline entity)
    {
        _disciplines.Add(entity);
    }

    public void Update(Discipline entity)
    {
        var discipline = ReadById(entity.Id);

        if (discipline != null)
        {
            _disciplines.Remove(discipline);
            _disciplines.Add(entity);
        }
    }

    public void Delete(int id)
    {
        var discipline = ReadById(id);

        if (discipline != null)
        {
            _disciplines.Remove(discipline);
        }
    }
}
