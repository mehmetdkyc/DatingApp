using API.Data;
using API.InterFaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            //startup sınıfını temiz tutmak için bazı servisleri böyle extensions ile ayırdık.
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options=>{
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}