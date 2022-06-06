using Microsoft.Extensions.DependencyInjection;
using PsicopataImagenes.Application.Interfaces;
using PsicopataImagenes.Application.Services;
using PsicopataImagenes.Infraestructure.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataImagenes.Infraestructure.IoC
{
   public static class ServicesRegister
    {
        public static IServiceCollection addServicesColleton(this IServiceCollection services) 
        {
            services.AddScoped<IFileServices, FileServices>();
            services.AddScoped<IFileRepository, FileRepository>();
            return services;
        }
    }
}
