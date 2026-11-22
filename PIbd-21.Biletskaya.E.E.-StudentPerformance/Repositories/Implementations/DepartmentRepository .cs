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

public class DepartmentRepository : IDepartmentRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public DepartmentRepository(DataContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<Department> ReadAll()
    {
        try
        {
            var departments = _context.Departments.ToList();

            _logger.LogInformation(
                "Получен список кафедр. Количество: {Count}",
                departments.Count);

            return departments;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при получении списка кафедр");
            throw;
        }
    }

    public Department? ReadById(int id)
    {
        try
        {
            var department = _context.Departments
                .FirstOrDefault(x => x.Id == id);

            _logger.LogInformation(
                "Выполнен поиск кафедры с ID {Id}. Найдена: {Found}",
                id, department != null);

            return department;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Ошибка при поиске кафедры с ID {Id}", id);
            throw;
        }
    }

    public void Create(Department entity)
    {
        try
        {
            _context.Departments.Add(entity);
            _context.SaveChanges();

            _logger.LogInformation(
                "Добавлена кафедра с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении кафедры");
            throw;
        }
    }

    public void Update(Department entity)
    {
        try
        {
            var existingEntity = _context.Departments
                .FirstOrDefault(x => x.Id == entity.Id);

            if (existingEntity == null)
            {
                _logger.LogWarning(
                    "Не удалось изменить кафедру. ID {Id} не найден",
                    entity.Id);
                return;
            }

            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            _logger.LogInformation(
                "Изменена кафедра с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Ошибка при изменении кафедры с ID {Id}", entity.Id);
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            var entity = _context.Departments.Find(id);

            if (entity == null)
            {
                _logger.LogWarning(
                    "Не удалось удалить кафедру. ID {Id} не найден", id);
                return;
            }

            _context.Departments.Remove(entity);
            _context.SaveChanges();

            _logger.LogInformation(
                "Удалена кафедра с ID {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,
                "Ошибка при удалении кафедры с ID {Id}", id);
            throw;
        }
    }
}
