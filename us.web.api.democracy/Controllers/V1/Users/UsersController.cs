using MediatR;
using Microsoft.AspNetCore.Mvc;
using U1 = Us.Web.Api.Democracy.Handlers.V1.Users;

namespace Us.Web.Api.Democracy.Controllers.V1.Users
{
    public class UsersController : Base
    {
        private readonly IMediator mediator;

        public UsersController(IMediator mediator) => this.mediator = mediator;

        [HttpGet("")]
        public async Task<IActionResult> Get()
            => Respond(await mediator.Send(new U1.GetUser()));

    }
}