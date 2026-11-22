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

public class TeacherRepository : ITeacherRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public TeacherRepository(DataContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<Teacher> ReadAll()
    {
        try
        {
            var teachers = _context.Teachers.ToList();
            _logger.LogInformation("Получен список преподавателей. Количество: {Count}", teachers.Count);
            return teachers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при получении списка преподавателей");
            throw;
        }
    }

    public Teacher? ReadById(int id)
    {
        try
        {
            var teacher = _context.Teachers.FirstOrDefault(x => x.Id == id);
            _logger.LogInformation("Поиск преподавателя с ID {Id}. Найден: {Found}", id, teacher != null);
            return teacher;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске преподавателя с ID {Id}", id);
            throw;
        }
    }

    public void Create(Teacher entity)
    {
        try
        {
            _context.Teachers.Add(entity);
            _context.SaveChanges();
            _logger.LogInformation("Добавлен преподаватель с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении преподавателя");
            throw;
        }
    }

    public void Update(Teacher entity)
    {
        try
        {
            var existingEntity = _context.Teachers.FirstOrDefault(x => x.Id == entity.Id);

            if (existingEntity == null)
            {
                _logger.LogWarning("Преподаватель с ID {Id} не найден для изменения", entity.Id);
                return;
            }

            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            _logger.LogInformation("Изменён преподаватель с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при изменении преподавателя с ID {Id}", entity.Id);
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            var entity = _context.Teachers.Find(id);

            if (entity == null)
            {
                _logger.LogWarning("Преподаватель с ID {Id} не найден для удаления", id);
                return;
            }

            _context.Teachers.Remove(entity);
            _context.SaveChanges();

            _logger.LogInformation("Удалён преподаватель с ID {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении преподавателя с ID {Id}", id);
            throw;
        }
    }
}
