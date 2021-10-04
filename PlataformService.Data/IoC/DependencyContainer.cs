using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlataformService.Data.Context;
using PlataformService.Data.Repository;
using PlataformService.Domain.Interface.IRepository;
using PlataformService.Domain.Interface.IService;
using PlataformService.Domain.Interface.UnitOfWork;
using PlataformService.Service.Service;
using System;

namespace PlataformService.Data.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, string connectionString, IConfiguration Configuration)
        {
            //Context
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            //Services
            services.AddTransient<IPlatformService, PlatformService>();

            //Repository
            services.AddTransient<IPlatformRepository, PlatformRepository>();
            services.AddTransient<IUnitOfWork, Repository.UnitOfWork.UnitOfWork>();

            //AutoMapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
