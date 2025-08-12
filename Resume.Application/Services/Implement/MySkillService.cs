using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities;
using Resume.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement;

public class MySkillService : IMySkillService
{
    #region Ctor

    private readonly IMySkillsRepository _mySkillsRepository;
    private readonly IUnitOfWork _unitOfWork;

    public MySkillService(IMySkillsRepository mySkillsRepsitory,
        IUnitOfWork unitOfWork)
    {
        _mySkillsRepository = mySkillsRepsitory;
        _unitOfWork = unitOfWork;
    }

    #endregion

    public List<MySkills> GetListOfMySkills()
        => _mySkillsRepository.GetListOfMySkills();

    public MySkills? FindOne(int id)
    => _mySkillsRepository.FindOne(id);

    public void CreateMySkill(MySkills mySkills)
    {
        _mySkillsRepository.Add(mySkills);
        _unitOfWork.SaveChanges();
    }

    public void UpdateMySkill(MySkills mySkills)
    {
        _mySkillsRepository.Update(mySkills);
        _unitOfWork.SaveChanges();
    }

    public void DeleteMySkill(MySkills mySkills)
    {
        _mySkillsRepository.Remove(mySkills);
        _unitOfWork.SaveChanges();
    }
}
