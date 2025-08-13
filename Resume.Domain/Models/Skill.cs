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
    public string Name = null!;
    public string Description = null!;
    public SkillLevel(int level)
    {
        switch (level)
        {
            case 0:
                Name = "Beginner";
                Description = "";
                break;
            case 1:
                Name = "Intermediate";
                Description = "";
                break;
            case 2:
                Name = "Senior";
                Description = "";
                break;
            default:
                break;
        }
    }
}
