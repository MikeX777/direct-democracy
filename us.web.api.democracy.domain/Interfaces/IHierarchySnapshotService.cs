using LanguageExt;
using Us.Web.Api.Democracy.Model.Error;

namespace Us.Web.Api.Democracy.Domain.Intefaces
{
    public interface IHierarchySnapshotService
    {
        Task<Either<ErrorResponse, double>> GetHierarchySnapshot(int userId);
    }
}