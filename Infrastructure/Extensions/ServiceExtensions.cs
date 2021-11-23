using Hangfire;
using Hangfire.MemoryStorage;
using jobPortalAPI.Data;
using jobPortalAPI.Domain.Services;
using jobPortalAPI.Profiles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace jobPortalAPI.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            // Database Connection
            services.AddDbContext<DataDbContext>(opt => 
                opt.UseNpgsql(config.GetConnectionString("DbConnection")));
            

            // NewtonsoftJson and Policy
            services.AddControllers(opt =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                opt.Filters.Add(new AuthorizeFilter(policy));
            }).AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            
            
            // Connection 
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IJobService, JobService>();
            
            
            // AutoMapper
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            services.AddAutoMapper(typeof(JobPostMappingProfile).Assembly);
            
            
            // HangFire
            services.AddHangfire(opt => opt.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                    .UseSimpleAssemblyNameTypeSerializer()
                    .UseDefaultTypeSerializer().UseMemoryStorage());
            
            
            services.AddHangfireServer();
            services.AddHttpClient();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            
            
            // Swagger
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo {Title = "JobPortalAPI", Version = "v1"});
                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter `Bearer` [space] and then your valid token in the input below. \r\n\r\nExample: \"Bearer some valid token here...\""
                });
                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });
            
            
            return services;
        }
    }
}