using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlataformService.Data.Context;
using PlataformService.Data.Repository;
using PlataformService.Domain.Interface.IRepository;
using PlataformService.Domain.Interface.IService;
using PlataformService.Domain.Interface.UnitOfWork;
using PlataformService.Domain.Request;
using PlataformService.Service.Service;
using PlataformService.Service.Validators;
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

            // Unit Of Work
            services.AddTransient<IUnitOfWork, Repository.UnitOfWork.UnitOfWork>();

            //AutoMapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransient<IValidator<PlatformPutRequest>, PlatformPutRequestValidator>();
            services.AddTransient<IValidator<PlatformPostRequest>, PlatformPostRequestValidator>();

        }
    }
}
