using System.Net;

namespace TemplateService.Models.Exceptions;

public class EmployeeNotFound : Error
{
    public EmployeeNotFound(Guid? id = null)
        : base(HttpStatusCode.NotFound, id != null ? "Could not find employee of id: " + id : "Employee not found", "Could not find anything on that employee...")
    {

    }
}