using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs;

public class CreateAnEducationAdminSideDTO
{
    [Required]
    public string EducationTitle { get; set; } = null!;

    [Required]
    public string EducationDuration { get; set; } = null!;

    [Required]
    public string? Description { get; set; }
}
