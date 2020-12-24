namespace TravelPointSystem.Web.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using TravelPointSystem.Data;
    using TravelPointSystem.Data.Common;
    using TravelPointSystem.Data.Common.Repositories;
    using TravelPointSystem.Data.Models;
    using TravelPointSystem.Data.Repositories;
    using TravelPointSystem.Services.Data;
    using TravelPointSystem.Services.Messaging;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(
          this IServiceCollection services,
          IConfiguration configuration)
          => services
               .AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(
                       configuration.GetConnectionString("DefaultConnection")));

        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services
                .AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
                .AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services
                .Configure<CookiePolicyOptions>(
                    options =>
                    {
                        options.CheckConsentNeeded = context => true;
                        options.MinimumSameSitePolicy = SameSiteMode.None;
                    });

            return services;
        }

        public static IServiceCollection AddMvcControllers(this IServiceCollection services)
        {
            services
                .AddControllersWithViews(configure =>
                {
                    configure.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                });

            services
                .AddRazorPages();

            return services;
        }

        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddSingleton(configuration)
                .AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>))
                .AddScoped<IDbQueryRunner, DbQueryRunner>()
                .AddTransient<IEmailSender, NullMessageSender>()
                .AddTransient<IDestinationsService, DestinationsService>()
                .AddTransient<IUsersService, UsersService>()
                .AddTransient<IHotelsService, HotelsService>()
                .AddTransient<IOrganizedTripsService, OrganizedTripsService>()
                .AddTransient<IFlightsService, FlightsService>()
                .AddTransient<IBusesService, BusesService>()
                .AddTransient<IReservationsService, ReservationsService>()
                .AddTransient<IFlightCompaniesService, FlightCompaniesService>(); 
    }
}
