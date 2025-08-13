using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities;
using Resume.Domain.IRepository;
using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public EmployeeService(IEmployeeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public List<Employer> AddAcceptedByEmployers(Employer employer)
    => _repository.AddAcceptedByEmployers(employer);

    public List<Employer> AddAppliedByEmployers(Employer employer)
    => _repository.AddAppliedByEmployers(employer);

    public List<Experience> AddExperience(Experience experience)
    =>_repository.AddExperience(experience);

    public List<Skill> AddSkillToList(Skill skill)
    =>_repository.AddSkillToList(skill);

    public List<Employer> DeleteAcceptedByEmployers(Employee employer)
    => _repository.DeleteAcceptedByEmployers(employer);

    public List<Employer> DeleteAppliedByEmployers(Employee employer)
    => _repository.DeleteAppliedByEmployers(employer);

    public List<Experience> DeleteExperience(Experience experience)
    =>_repository.DeleteExperience(experience);

    public List<Skill> DeleteSkillFromList(Skill skill)
    =>_repository.DeleteSkillFromList(skill);

    public List<Employer> GetAcceptedByEmployers(List<Employer> employers)
    => _repository.GetAcceptedByEmployers(employers);

    public List<Employer> GetAppliedByEmployers(List<Employer> employers)
    => _repository.GetAppliedByEmployers(employers);

    public Employee GetById(int id)
    =>_repository.GetById(id);

    public List<Experience> GetExperiences(List<Experience> experiences)
    =>_repository.GetExperiences(experiences);

    public string GetFirstName(string name)
    =>_repository.GetFirstName(name);

    public int GetId(int id)
    =>_repository.GetId(id);

    public string GetLastName(string name)
    =>_repository.GetLastName(name);

    public List<Skill> GetSkillList(List<Skill> skills)
    =>_repository.GetSkillList(skills);

    public List<Skill> GetSkillList(Skill skill)
    => _repository.GetSkillList(skill);

    public void UpdateAll()
    => _unitOfWork.SaveChanges();
}
