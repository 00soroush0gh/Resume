using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities;

public class Experience
{
    public int Id { get; set; }

    public string ExperienceTitle { get; set; } = null!;

    public string ExperienceDuration { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? CompanySite { get; set; }
}
