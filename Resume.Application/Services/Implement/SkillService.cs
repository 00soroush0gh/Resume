using Resume.Application.Services.Interfaces;
using Resume.Domain.IRepository;
using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement;

public class SkillService : ISkillService
{
    private readonly ISkillRepository _skillRepository;
    private readonly IUnitOfWork _unitOfWork;
    public SkillService(ISkillRepository skillRepository,IUnitOfWork unitOfWork)
    {
        _skillRepository = skillRepository;
        _unitOfWork = unitOfWork;
    }

    public List<Skill> AddSkill(Skill skill)
    =>_skillRepository.AddSkill(skill);

    public List<Skill> DeleteSkill(Skill skill)
    =>_skillRepository.DeleteSkill(skill);

    public Skill? FindOne(int id)
    =>_skillRepository.FindOne(id);

    public List<Skill> GetListOfSkills()
    =>_skillRepository.GetListOfSkill();

    public List<Skill> UpdateSkill(Skill skill)
    =>_skillRepository.UpdateSkill(skill);

    public List<Skill> AddSubSkill(Skill skill)
    =>_skillRepository.AddSubSkill(skill);

    public SkillLevel GetSkillLevel(SkillLevel skillLevel)
    =>_skillRepository.GetSkillLevel(skillLevel);

    public SkillLevel UpdateSkillLevel(SkillLevel skillLevel)
    =>_skillRepository.UpdateSkillLevel(skillLevel);
}
