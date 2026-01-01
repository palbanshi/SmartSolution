using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Smartsolutions.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartsolutions.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration) {
            var connectionString = configuration.GetConnectionString("SmartsolutionsDb");
            services.AddDbContext<SmartsolutionsDbContext>(Options =>Options.UseNpgsql(connectionString));
            services.AddScoped<ISmartsolutionsSeeders, SmartsolutionsSeeders>();
        }
    }
}
