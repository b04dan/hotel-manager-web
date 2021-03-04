using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HotelManager.DAL.EF;
using Microsoft.EntityFrameworkCore;
using HotelManager.DAL.Interfaces;
using HotelManager.BLL.MappingProfiles;
using HotelManager.BLL.Interfaces;
using HotelManager.BLL.Services;
using System;
using AutoMapper;

namespace HotelManager.ROOT
{
    public static class CompositionRoot
    {
        public static void InjectDependencies(IServiceCollection services, IConfiguration configuration, Action<IMapperConfigurationExpression> configAction)
        {
            // AutoMapper
            services.AddAutoMapper(configAction);

            // Database
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<HotelDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, EFUnitOfWork>();

            // Repositories
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));

            // Services
            services.AddScoped<IClientsService, ClientsService>();
            services.AddScoped<IHotelRoomsService, HotelRoomsService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IResidencesService, ResidencesService>();
            services.AddScoped<ISchedulesService, SchedulesService>();
            services.AddScoped<IWorkersService, WorkersService>();
            services.AddScoped<IStatisticsService, StatisticsService>();
        }
    }
}
