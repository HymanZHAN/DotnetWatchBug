using System.Text;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {
            Console.WriteLine($"config token key: {config["TokenKey"]}");
            Console.WriteLine(Encoding.UTF8.GetBytes(config["TokenKey"]));
            return services;
        }
    }
}