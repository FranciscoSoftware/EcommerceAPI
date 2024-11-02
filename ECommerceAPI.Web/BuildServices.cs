using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Data;
namespace ECommerceAPI.Web
{
    public static class BuildServices
    {
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            // Configure Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configure DbContext with Cosmos DB
            builder.Services.AddDbContext<ECommerceContext>(options =>
                options.UseCosmos(
                    builder?.Configuration["CosmosDb:AccountEndpoint"]!,
                    builder?.Configuration["CosmosDb:AccountKey"]!,
                    builder?.Configuration["CosmosDb:DatabaseName"]!
                )
            );
        }
    }
}