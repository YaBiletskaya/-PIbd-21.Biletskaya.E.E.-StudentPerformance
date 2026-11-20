using PIbd_21.Biletskaya.E.E._StudentPerformance.Data;
using PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Repositories.Implementations;

public class FacultyRepository : IFacultyRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public FacultyRepository(DataContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<Faculty> ReadAll()
    {
        try
        {
            var faculties = _context.Faculties.ToList();
            _logger.LogInformation(
                "Получен список факультетов. Количество: {Count}",
                faculties.Count);

            return faculties;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при получении списка факультетов");
            throw;
        }
    }

    public Faculty? ReadById(int id)
    {
        try
        {
            var faculty = _context.Faculties
                .FirstOrDefault(x => x.Id == id);

            _logger.LogInformation(
                "Выполнен поиск факультета с ID {Id}. Найден: {Found}",
                id, faculty != null);

            return faculty;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Ошибка при поиске факультета с ID {Id}", id);
            throw;
        }
    }

    public void Create(Faculty entity)
    {
        try
        {
            _context.Faculties.Add(entity);
            _context.SaveChanges();

            _logger.LogInformation(
                "Добавлен факультет с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении факультета");
            throw;
        }
    }

    public void Update(Faculty entity)
    {
        try
        {
            var existingEntity = _context.Faculties
                .FirstOrDefault(x => x.Id == entity.Id);

            if (existingEntity == null)
            {
                _logger.LogWarning(
                    "Не удалось изменить факультет. ID {Id} не найден",
                    entity.Id);
                return;
            }

            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            _logger.LogInformation(
                "Изменён факультет с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Ошибка при изменении факультета с ID {Id}", entity.Id);
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            var faculty = _context.Faculties.Find(id);

            if (faculty == null)
            {
                _logger.LogWarning(
                    "Не удалось удалить факультет. ID {Id} не найден", id);
                return;
            }

            _context.Faculties.Remove(faculty);
            _context.SaveChanges();

            _logger.LogInformation(
                "Удалён факультет с ID {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Ошибка при удалении факультета с ID {Id}", id);
            throw;
        }
    }
}
