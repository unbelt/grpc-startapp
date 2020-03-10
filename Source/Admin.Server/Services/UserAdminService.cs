using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Admin.Server.Services
{
    public class UserAdminService : UserAdmin.UserAdminBase
    {
        private readonly ILogger<UserAdminService> _logger;

        public UserAdminService(ILogger<UserAdminService> logger)
        {
            _logger = logger;
        }

        public override Task<UserReply> GetUserInfo(UserRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Getting user info...");

            return Task.FromResult(new UserReply
            {
                Id = 3,
                Name = "Jeff"
            });
        }
    }
}
