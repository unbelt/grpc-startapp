using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Admin.Server.Services
{
    public class OrderAdminService : OrderAdmin.OrderAdminBase
    {
        private readonly ILogger<OrderAdminService> _logger;

        public OrderAdminService(ILogger<OrderAdminService> logger)
        {
            _logger = logger;
        }

        public override Task<OrderModel> GetOrderInfo(OrderRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Getting order info...");

            return Task.FromResult(new OrderModel
            {
                Name = "Bike",
                Price = 120,
                InStock = true
            });
        }
    }
}
