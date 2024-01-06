using TemplateService.Contracts;
using TemplateService.Models;

namespace TemplateService.Services.Employees;

public interface IEmployeeService
{
    Result<Employee> GetEmployeeById(Guid id);

    Result<IEnumerable<Employee>> GetEmployees();

    Result CreateOrUpdateEmployee(Employee employee);
    
    Result DeleteEmployeeById(Guid id);
}