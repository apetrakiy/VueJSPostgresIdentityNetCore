using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserService.Api.Entities;

namespace UserService.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationClaimsPrincipalFactory>();

            services.AddDbContext<UserServiceDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<UserServiceDbContext>()
                .AddDefaultTokenProviders();

        }
    }
}