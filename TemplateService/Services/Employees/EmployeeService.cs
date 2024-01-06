using Swan;
using TemplateService.Contracts;
using TemplateService.Models;
using TemplateService.Models.Exceptions;
using TemplateService.Repositories.Employees;

namespace TemplateService.Services.Employees;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        this.repository = repository;
    }

    public Result<Employee> GetEmployeeById(Guid id)
    {
        var employee = repository.GetEmployeeById(id).Await();

        if (employee == null)
        {
            return Result.Failure(new EmployeeNotFound(id));
        }

        return Result<Employee>.Success(employee);
    }

    public Result<IEnumerable<Employee>> GetEmployees()
    {
        var employees = repository.GetEmployees().Await();
        return Result<IEnumerable<Employee>>.Success(employees);
    }

    public Result CreateOrUpdateEmployee(Employee employee)
    {
        repository.CreateOrUpdateEmployee(employee).Await();
        return Result.Success(employee);
    }

    public Result DeleteEmployeeById(Guid id)
    {
        repository.DeleteEmployeeById(id).Await();
        return Result.Success();
    }
}
