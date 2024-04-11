using DotNetDesafio.Infrastructure.Data;
using DotNetDesafio.Infrastructure.Data.Interface;
using DotNetDesafio.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetDesafio.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();

            return services;
        }
    }
}
