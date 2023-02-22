using System.Net;

namespace Us.Web.Api.Democracy.Model.Error
{
    public class ApiProblemDetails 
    {
        public string Title { get; set; } = string.Empty;
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; } = string.Empty;
        
    }
}