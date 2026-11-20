using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

public class Faculty
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string DeanFullName { get; private set; } = string.Empty;

    private Faculty()
    {
    }

    public static Faculty CreateEntity(
        int id,
        string? name,
        string? deanFullName)
    {
        return new Faculty
        {
            Id = id,
            Name = name ?? string.Empty,
            DeanFullName = deanFullName ?? string.Empty
        };
    }
}
