using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Domain.Entities;
using PestKitOnion.Persistence.Contexts;
using PestKitOnion.Persistence.Implementations.Repositories;
using PestKitOnion.Persistence.Implementations.Services;

namespace PestKitOnion.Persistence.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;

                opt.User.RequireUniqueEmail = true;

                opt.Lockout.AllowedForNewUsers = true;
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromMinutes(5);
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();


            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IAuthorService, AuthorService>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDepartmentService, DepartmentService>();

            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITagService,TagService>();

            services.AddScoped<IPositionRepository,PositionRepository>();
            services.AddScoped<IPositionService,PositionService>();

            services.AddScoped<IEmployeeRepository,EmployeeRepository>();
            services.AddScoped<IEmployeeService,EmployeeService>();

            services.AddScoped<IBlogRepository,BlogRepository>();
            services.AddScoped<IBlogService,BlogService>();

            services.AddScoped<IAuthService,AuthService>();

            return services;
        }
    }
}
