using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces;

public interface IMySkillService
{
    List<MySkills> GetListOfMySkills();
    MySkills? FindOne(int id);
    void CreateMySkill(MySkills mySkills);
    void UpdateMySkill(MySkills mySkills);
    void DeleteMySkill(MySkills mySkills);
}
