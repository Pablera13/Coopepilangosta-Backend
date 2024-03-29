﻿using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApiContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CoopePilangostaBD") ?? throw new InvalidOperationException("Connection string 'CoopePilangostaBD' not found.")));

            services.AddScoped<ApiContext>();

            return services;
        }
    }
}
