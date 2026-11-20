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

public class StudentRepository : IStudentRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public StudentRepository(DataContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<Student> ReadAll()
    {
        try
        {
            var students = _context.Students.ToList();
            _logger.LogInformation("Получен список студентов. Количество: {Count}", students.Count);
            return students;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при получении списка студентов");
            throw;
        }
    }

    public Student? ReadById(int id)
    {
        try
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            _logger.LogInformation("Поиск студента с ID {Id}. Найден: {Found}", id, student != null);
            return student;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске студента с ID {Id}", id);
            throw;
        }
    }

    public void Create(Student entity)
    {
        try
        {
            _context.Students.Add(entity);
            _context.SaveChanges();
            _logger.LogInformation("Добавлен студент с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении студента");
            throw;
        }
    }

    public void Update(Student entity)
    {
        try
        {
            var existingEntity = _context.Students.FirstOrDefault(x => x.Id == entity.Id);

            if (existingEntity == null)
            {
                _logger.LogWarning("Студент с ID {Id} не найден для изменения", entity.Id);
                return;
            }

            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            _logger.LogInformation("Изменён студент с ID {Id}", entity.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при изменении студента с ID {Id}", entity.Id);
            throw;
        }
    }

    public void Delete(int id)
    {
        try
        {
            var entity = _context.Students.Find(id);

            if (entity == null)
            {
                _logger.LogWarning("Студент с ID {Id} не найден для удаления", id);
                return;
            }

            _context.Students.Remove(entity);
            _context.SaveChanges();

            _logger.LogInformation("Удалён студент с ID {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении студента с ID {Id}", id);
            throw;
        }
    }
}
