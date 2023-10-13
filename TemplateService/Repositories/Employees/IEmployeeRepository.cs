using TemplateService.Contracts;

namespace TemplateService.Repositories.Employees;

public interface IEmployeeRepository
{
    Task<Employee> GetEmployeeById(Guid id);

    Task CreateOrUpdateEmployee(Employee employee);
    
    Task<IEnumerable<Employee>> GetEmployees();
    
    Task DeleteEmployeeById(Guid id);
}
