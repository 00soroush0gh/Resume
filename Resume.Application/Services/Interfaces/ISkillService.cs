using Resume.Domain.Entities;
using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces;

internal interface ISkillService
{
    List<Skill> GetListOfSkills();
    Skill? FindOne(int id);
    List<Skill> AddSkill(Skill skill);
    List<Skill> UpdateSkill(Skill skill);
    List<Skill> DeleteSkill(Skill skill);
    List<Skill> AddSubSkill(Skill skill);
    SkillLevel GetSkillLevel(SkillLevel skillLevel);
    SkillLevel UpdateSkillLevel(SkillLevel skillLevel);
}
