using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models;

public partial class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Skill>? SubSkill { get; set; } = new List<Skill>();
    public SkillLevel Level { get; set; } = null!;
    

}
public class SkillLevel
{
    public string Name { get; set; }
    public string Description { get; set; } = null!;
    
}
