using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PestKitOnion.Application.Validators;
using System.Reflection;

namespace PestKitOnion.Application.Abstractions.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddFluentValidation(options=>options.RegisterValidatorsFromAssemblyContaining(typeof(PositionCreateDtoValidator)));
    

            return services;
        }
    }
}
