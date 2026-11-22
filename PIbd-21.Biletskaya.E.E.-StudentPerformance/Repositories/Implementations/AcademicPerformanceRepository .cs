using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class AcademicPerformanceRepository : IAcademicPerformanceRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public AcademicPerformanceRepository(DataContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<AcademicPerformance> ReadAll()
    {
        try
        {
            var performances = _context.AcademicPerformances.ToList();

            _logger.LogInformation(
                "Получен список оценок. Количество: {Count}",
                performances.Count);

            return performances;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при получении списка оценок");
            throw;
        }
    }

    public AcademicPerformance? ReadById(int id)
    {
        try
        {
            var performance = _context.AcademicPerformances
                .FirstOrDefault(x => x.Id == id);

            _logger.LogInformation(
                "Поиск оценки с ID {Id}. Найдена: {Found}",
                id, performance != null);

            return performance;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске оценки с ID {Id}", id);
            throw;
        }
    }

    public void Create(AcademicPerformance entity)
    {
        try
        {
            _context.AcademicPerformances.Add(entity);
            _context.SaveChanges();

            _logger.LogInformation(
                "Добавлена оценка с ID {Id} для студента {StudentId}",
                entity.Id, entity.StudentId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении оценки");
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            var entity = _context.AcademicPerformances.Find(id);

            if (entity == null)
            {
                _logger.LogWarning("Оценка с ID {Id} не найдена для удаления", id);
                return;
            }

            _context.AcademicPerformances.Remove(entity);
            _context.SaveChanges();

            _logger.LogInformation("Удалена оценка с ID {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении оценки с ID {Id}", id);
            throw;
        }
    }
}
