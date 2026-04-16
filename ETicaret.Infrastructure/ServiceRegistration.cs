using ETicaret.Application.Interfaces;
using ETicaret.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaret.Infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // DbContext kaydı → connection string appsettings.json'dan okunur
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // IUnitOfWork → UnitOfWork
        // Scoped → her HTTP isteği için 1 instance oluşturulur, istek bitince silinir
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
