using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities;

public class Education
{
    public int Id { get; set; }

    public string EducationTitle { get; set; } = null!;

    public string EducationDuration { get; set; } = null!;

    public string? Description { get; set; }
}
