using Resume.Domain.Entities;
using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces;

public interface IEmployeeService
{
    public int GetId(int id);
    public Employee GetById(int id);
    public string GetFirstName(string name);
    public string GetLastName(string name);
    public List<Skill> GetSkillList(List<Skill> skills);
    public List<Skill> GetSkillList(Skill skill);
    public List<Skill> AddSkillToList(Skill skill);
    public List<Skill> DeleteSkillFromList(Skill skill);
    public List<Experience> GetExperiences(List<Experience> experiences);
    public List<Experience> AddExperience(Experience experience);
    public List<Experience> DeleteExperience(Experience experience);
    public List<Employer> GetAppliedByEmployers(List<Employer> employers);
    public List<Employer> AddAppliedByEmployers(Employer employer);
    public List<Employer> DeleteAppliedByEmployers(Employee employer);
    public List<Employer> GetAcceptedByEmployers(List<Employer> employers);
    public List<Employer> AddAcceptedByEmployers(Employer employer);
    public List<Employer> DeleteAcceptedByEmployers(Employee employer);
    public void UpdateAll();

}
