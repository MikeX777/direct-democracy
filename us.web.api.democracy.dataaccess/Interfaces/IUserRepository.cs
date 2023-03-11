using LanguageExt;
using Us.Web.Api.Democracy.Model.Error;
using Us.Web.Api.Democracy.Model.User;

namespace Us.Web.Api.Democracy.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        Task<Either<ErrorResponse, User>> GetUserById(int id);
    }
}