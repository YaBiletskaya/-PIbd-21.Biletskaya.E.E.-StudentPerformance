using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIbd_21.Biletskaya.E.E._StudentPerformance.Entities.Enums;

[Flags]
public enum AssessmentOptions
{
    None = 0,
    Exam = 1,
    Credit = 2,
    DifferentiatedCredit = 4,
    Coursework = 8,
    PracticalWork = 16
}
