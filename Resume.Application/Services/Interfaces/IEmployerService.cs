using Resume.Domain.Entities;
using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces;

public interface IEmployerService
{
    public int GetId(int id);
    public Employee GetById(int id);
    public List<Employee> GetEmployeesAplied(List<Employee> employers);
    public List<Employee> AddEmployeesAplied(Employee employer);
    public List<Employee> DeleteEmployeesAplied(Employee employer);
    public List<Employee> GetEmployeesAccepted(List<Employee> employers);
    public List<Employee> AddEmployeesAccepted(Employee employer);
    public List<Employee> DeleteEmployeesAccepted(Employee employer);
    public void UpdateAll();

}
