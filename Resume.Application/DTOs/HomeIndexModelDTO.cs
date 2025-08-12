using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs;

public class HomeIndexModelDTO
{
    public List<Education> Educations { get; set; } = new List<Education>();
    public List<Experience> Experiences { get; set; } = new List<Experience>();
    public List<MySkills> MySkills { get; set; } = new List<MySkills>();

}
