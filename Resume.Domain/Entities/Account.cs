using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Entities
{
    public abstract class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Email { get; set; }
    }
    public class Employee : Account
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<Skill> SkillList { get; set; } = new List<Skill>();
        public List<Experience> Experiences { get; set; } = new();
        public List<Employer> AppliedByEmployers { get; set; } = new();
        public List<Employer> AcceptedByEmployers { get; set; } = new();
    }
    public class Employer : Account
    {
        public Skill? FilterBySkill { get; set; }
        public List<Employee> EmployeesAplied { get; set; } = new();
        public List<Employee> EmployeesAccepted { get; set; } = new();

    }

}
