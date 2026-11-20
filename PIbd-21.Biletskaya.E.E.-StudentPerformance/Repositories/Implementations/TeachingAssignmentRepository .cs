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

public class TeachingAssignmentRepository : ITeachingAssignmentRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public TeachingAssignmentRepository(DataContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<TeachingAssignment> ReadAll()
    {
        try
        {
            var assignments = _context.TeachingAssignments.ToList();
            _logger.LogInformation("Получен список учебных назначений. Количество: {Count}", assignments.Count);
            return assignments;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при получении списка учебных назначений");
            throw;
        }
    }

    public TeachingAssignment? ReadById(int id)
    {
        try
        {
            var assignment = _context.TeachingAssignments.FirstOrDefault(x => x.Id == id);
            _logger.LogInformation("Поиск учебного назначения с ID {Id}. Найдено: {Found}", id, assignment != null);
            return assignment;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске учебного назначения с ID {Id}", id);
            throw;
        }
    }

    public void Create(TeachingAssignment entity)
    {
        try
        {
            _context.TeachingAssignments.Add(entity);
            _context.SaveChanges();
            _logger.LogInformation("Добавлено учебное назначение с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении учебного назначения");
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            var entity = _context.TeachingAssignments.Find(id);

            if (entity == null)
            {
                _logger.LogWarning("Учебное назначение с ID {Id} не найдено для удаления", id);
                return;
            }

            _context.TeachingAssignments.Remove(entity);
            _context.SaveChanges();

            _logger.LogInformation("Удалено учебное назначение с ID {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении учебного назначения с ID {Id}", id);
            throw;
        }
    }
}
