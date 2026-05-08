using ApsnetCoreMVC.Mappings;
using ApsnetCoreMVC.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApsnetCoreMVC
{
    public static class ApplicationProfile
    {
        public static IServiceCollection AddAutomapperConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            string conn = configuration.GetConnectionString("StrCon")
                   ?? throw new InvalidOperationException("Connection string 'StrCon' not found.");

            services.AddDbContext<ApplicationDbContext>(o =>
                o.UseSqlServer(conn));

            services.AddAutoMapper(typeof(MappingProfile));


            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}