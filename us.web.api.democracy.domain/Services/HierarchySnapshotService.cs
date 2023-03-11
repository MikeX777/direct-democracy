using LanguageExt;
using Us.Web.Api.Democracy.DataAccess.Interfaces;
using Us.Web.Api.Democracy.Domain.Intefaces;
using Us.Web.Api.Democracy.Model.Error;

namespace Us.Web.Api.Democracy.Domain.Services
{
    public class HierarchySnapshotService : IHierarchySnapshotService
    {
        private readonly IUserRepository userRepository;

        public HierarchySnapshotService(IUserRepository userRepository) => this.userRepository = userRepository;

        public async Task<Either<ErrorResponse, double>> GetHierarchySnapshot(int userId)
        {
            var response = await userRepository.GetUserById(userId);
            return response.Map(user => user.Followers < 1 ? 1 : 1 / (double)user.Followers);
        }
    }
}