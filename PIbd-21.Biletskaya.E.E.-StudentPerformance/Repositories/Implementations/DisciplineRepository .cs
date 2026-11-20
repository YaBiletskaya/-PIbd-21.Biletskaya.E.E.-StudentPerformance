using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class DisciplineRepository : IDisciplineRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public DisciplineRepository(DataContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<Discipline> ReadAll()
    {
        try
        {
            var disciplines = _context.Disciplines.ToList();
            _logger.LogInformation("Получен список дисциплин. Количество: {Count}", disciplines.Count);
            return disciplines;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при получении списка дисциплин");
            throw;
        }
    }

    public Discipline? ReadById(int id)
    {
        try
        {
            var discipline = _context.Disciplines.FirstOrDefault(x => x.Id == id);
            _logger.LogInformation("Поиск дисциплины с ID {Id}. Найдена: {Found}", id, discipline != null);
            return discipline;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске дисциплины с ID {Id}", id);
            throw;
        }
    }

    public void Create(Discipline entity)
    {
        try
        {
            _context.Disciplines.Add(entity);
            _context.SaveChanges();
            _logger.LogInformation("Добавлена дисциплина с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении дисциплины");
            throw;
        }
    }

    public void Update(Discipline entity)
    {
        try
        {
            var existingEntity = _context.Disciplines.FirstOrDefault(x => x.Id == entity.Id);

            if (existingEntity == null)
            {
                _logger.LogWarning("Дисциплина с ID {Id} не найдена для изменения", entity.Id);
                return;
            }

            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            _logger.LogInformation("Изменена дисциплина с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при изменении дисциплины с ID {Id}", entity.Id);
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            var entity = _context.Disciplines.Find(id);

            if (entity == null)
            {
                _logger.LogWarning("Дисциплина с ID {Id} не найдена для удаления", id);
                return;
            }

            _context.Disciplines.Remove(entity);
            _context.SaveChanges();

            _logger.LogInformation("Удалена дисциплина с ID {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении дисциплины с ID {Id}", id);
            throw;
        }
    }
}
