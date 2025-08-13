using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities;
using Resume.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement;

public class EmployerService : IEmployerService
{
    private readonly IEmployerRepository _Repository;
    private readonly IUnitOfWork _unitOfWork;

    public EmployerService(IEmployerRepository repository, IUnitOfWork unitOfWork)
    {
        _Repository = repository;
        _unitOfWork = unitOfWork;
    }
    public List<Employee> AddEmployeesAccepted(Employee employee)
    =>_Repository.AddEmployeesAccepted(employee);

    public List<Employee> AddEmployeesAplied(Employee employee)
    => _Repository.AddEmployeesAplied(employee);

    public List<Employee> DeleteEmployeesAccepted(Employee employee)
    =>_Repository.DeleteEmployeesAccepted(employee);

    public List<Employee> DeleteEmployeesAplied(Employee employee)
    =>_Repository.DeleteEmployeesAplied(employee);

    public Employee GetById(int id)
    =>_Repository.GetById(id);

    public List<Employee> GetEmployeesAccepted(List<Employee> employee)
    =>_Repository.GetEmployeesAccepted(employee);

    public List<Employee> GetEmployeesAplied(List<Employee> employee)
    => _Repository.GetEmployeesAplied(employee);

    public int GetId(int id)
    => _Repository.GetId(id);

    public void UpdateAll()
    => _unitOfWork.SaveChanges();
}
