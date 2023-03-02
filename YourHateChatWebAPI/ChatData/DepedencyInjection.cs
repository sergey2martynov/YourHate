using ChatApplication.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatData
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];

            services.AddDbContext<MessageDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IMessageDbContext>(provider =>
                provider.GetService<MessageDbContext>());

            return services;

        }
    }
}
