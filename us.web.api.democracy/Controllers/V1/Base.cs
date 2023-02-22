using System.Net;
using LanguageExt;
using Microsoft.AspNetCore.Mvc;
using Us.Web.Api.Democracy.Model.Error;

namespace Us.Web.Api.Democracy.Controllers
{
    public class Base : ControllerBase 
    {
        public IActionResult Respond<T>(Either<ApiProblemDetails, T> response,
        Func<T, IActionResult>? happyPathResponse = null) =>
            response.Match(
                r => happyPathResponse == null ? Ok(r) : happyPathResponse(r),
                l => l.Status switch 
                {
                    HttpStatusCode.NotFound => NotFound(l),
                    HttpStatusCode.Forbidden => Forbid(),
                    HttpStatusCode.BadRequest => BadRequest(l),
                    _ => StatusCode((int)HttpStatusCode.InternalServerError, l)
                });
    }
}

