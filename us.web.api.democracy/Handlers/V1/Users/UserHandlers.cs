using LanguageExt;
using MediatR;
using Us.Web.Api.Democracy.Model.Error;

namespace Us.Web.Api.Democracy.Handlers.V1.Users
{
    public record GetUser() : IRequest<Either<ApiProblemDetails, bool>> { }

    public class UserHandlers :
        IRequestHandler<GetUser, Either<ApiProblemDetails, bool>>
    {
        public async Task<Either<ApiProblemDetails, bool>> Handle(GetUser request, CancellationToken cancellationToken) =>
            true;
    }
}