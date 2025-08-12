using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.IRepository;

public interface IMySkillsRepository
{
    List<MySkills> GetListOfMySkills();
    MySkills? FindOne(int id);
    void Add(MySkills mySkill);
    void Remove(MySkills mySkill);
    void Update(MySkills mySkills);
}
