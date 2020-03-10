using System;
using System.Threading.Tasks;
using Admin.Server;
using Grpc.Net.Client;

namespace Admin.Client
{
    class Program
    {
        static async Task Main()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            // User
            var userClient = new UserAdmin.UserAdminClient(channel);
            var userRequest = new UserRequest { Id = 1 };
            var user = await userClient.GetUserInfoAsync(userRequest);

            // Order
            var orderClient = new OrderAdmin.OrderAdminClient(channel);
            var orderRequest = new OrderRequest { OrderId = 1 };
            var order = await orderClient.GetOrderInfoAsync(orderRequest);

            Console.WriteLine($"{user.Name} with ID {user.Id} has a {order.Name} for ${order.Price}.");

            Console.ReadLine();
        }
    }
}
