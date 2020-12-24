namespace TravelPointSystem.Web.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;
    using TravelPointSystem.Data;
    using TravelPointSystem.Data.Seeding;
    using TravelPointSystem.Services.Mapping;
    using TravelPointSystem.Web.ViewModels;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder ApplyMigrations(this IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();

            var dbContext = services.ServiceProvider.GetService<ApplicationDbContext>();

            dbContext.Database.Migrate();

            return app;
        }

        public static IApplicationBuilder SeedData(this IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();

            var dbContext = services
                .ServiceProvider
                .GetService<ApplicationDbContext>();

            new ApplicationDbContextSeeder()
                    .SeedAsync(dbContext, services.ServiceProvider)
                    .GetAwaiter()
                    .GetResult();

            return app;
        }

        public static IApplicationBuilder RegisterAutoMapperMappings(this IApplicationBuilder app)
        {
            AutoMapperConfig
                .RegisterMappings(
                    typeof(ErrorViewModel).GetTypeInfo().Assembly);

            return app;
        }

        public static IApplicationBuilder SetCulture(this IApplicationBuilder app)
        {
            var cultureInfo = new CultureInfo("en-US");
            cultureInfo.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            return app;
        }
    }
}
