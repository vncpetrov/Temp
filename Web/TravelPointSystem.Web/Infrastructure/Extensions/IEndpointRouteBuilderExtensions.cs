namespace TravelPointSystem.Web.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Routing;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public static class IEndpointRouteBuilderExtensions
    {
        public static IEndpointRouteBuilder MapRoutes(this IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder
                .MapControllerRoute(
                    name: "areaRoute",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            endpointRouteBuilder
                .MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            endpointRouteBuilder
                .MapRazorPages();

            return endpointRouteBuilder;
        }
    }
}