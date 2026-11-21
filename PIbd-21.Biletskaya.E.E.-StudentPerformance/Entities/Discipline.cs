using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities;

public class Discipline
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public int Hours { get; private set; }

    public decimal Credits { get; private set; }

    private Discipline()
    {
    }

    public static Discipline CreateEntity(
        int id,
        string? name,
        int hours,
        decimal credits)
    {
        return new Discipline
        {
            Id = id,
            Name = name ?? string.Empty,
            Hours = hours,
            Credits = credits
        };
    }
}
