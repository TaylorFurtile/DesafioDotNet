﻿using DotNetDesafio.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

namespace DotNetDesafio.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();

            return services;
        }
    }
}
