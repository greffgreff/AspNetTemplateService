using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace TemplateService.Models;

public abstract class Error
{
    public string Message { get; set; }
    public string? FriendlyMessage { get; set; }
    public StatusCodeResult Status { get; set; }
    public DateTime UtcTime { get; set; }

    protected Error(HttpStatusCode status, string message = "", string friendlyMessage = "") 
    {
        Status = new StatusCodeResult((int)status);
        Message = message;
        FriendlyMessage = friendlyMessage;
        UtcTime = DateTime.UtcNow;
    }
}
