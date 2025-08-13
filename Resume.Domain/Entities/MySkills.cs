using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities;

public class MySkills
{
    public int Id { get; set; }

    public string SkillTille { get; set; } = null!;

    public int Percentage { get; set; }
    public List<Skill> SkillList { get; set; } = new List<Skill>();
}
