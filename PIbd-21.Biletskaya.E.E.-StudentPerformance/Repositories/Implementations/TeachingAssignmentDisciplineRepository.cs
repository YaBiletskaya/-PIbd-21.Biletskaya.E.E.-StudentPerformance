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

public class TeachingAssignmentDisciplineRepository : ITeachingAssignmentDisciplineRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public TeachingAssignmentDisciplineRepository(DataContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<TeachingAssignmentDiscipline> ReadAll()
    {
        try
        {
            var records = _context.TeachingAssignmentDisciplines.ToList();

            _logger.LogInformation(
                "Получен список связей учебных назначений и дисциплин. Количество: {Count}",
                records.Count);

            return records;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при получении списка связей учебных назначений и дисциплин");
            throw;
        }
    }

    public TeachingAssignmentDiscipline? ReadById(int id)
    {
        try
        {
            var record = _context.TeachingAssignmentDisciplines
                .FirstOrDefault(x => x.Id == id);

            _logger.LogInformation(
                "Поиск связи с ID {Id}. Найдена: {Found}",
                id, record != null);

            return record;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске связи с ID {Id}", id);
            throw;
        }
    }

    public void Create(TeachingAssignmentDiscipline entity)
    {
        using var transaction = _context.Database.BeginTransaction();

        try
        {
            bool assignmentExists = _context.TeachingAssignments
                .Any(x => x.Id == entity.TeachingAssignmentId);

            bool disciplineExists = _context.Disciplines
                .Any(x => x.Id == entity.DisciplineId);

            if (!assignmentExists)
                throw new InvalidOperationException(
                    "Учебное назначение не найдено.");

            if (!disciplineExists)
                throw new InvalidOperationException(
                    "Дисциплина не найдена.");

            _context.TeachingAssignmentDisciplines.Add(entity);
            _context.SaveChanges();

            transaction.Commit();

            _logger.LogInformation(
                "Добавлена связь учебного назначения {AssignmentId} с дисциплиной {DisciplineId}. ID записи: {Id}",
                entity.TeachingAssignmentId,
                entity.DisciplineId,
                entity.Id);
        }
        catch (Exception ex)
        {
            transaction.Rollback();

            _logger.LogError(
                ex,
                "Ошибка при добавлении связи учебного назначения {AssignmentId} с дисциплиной {DisciplineId}. Транзакция отменена",
                entity.TeachingAssignmentId,
                entity.DisciplineId);

            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            var entity = _context.TeachingAssignmentDisciplines.Find(id);

            if (entity == null)
            {
                _logger.LogWarning("Связь с ID {Id} не найдена для удаления", id);
                return;
            }

            _context.TeachingAssignmentDisciplines.Remove(entity);
            _context.SaveChanges();

            _logger.LogInformation("Удалена связь с ID {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении связи с ID {Id}", id);
            throw;
        }
    }
}
