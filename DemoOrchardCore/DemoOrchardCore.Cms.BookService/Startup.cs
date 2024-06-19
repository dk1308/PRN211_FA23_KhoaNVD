using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace DemoOrchardCore.Cms.BookService
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            //builder.UseRouting();
            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "DemoOrchardCore.Cms.BookService",
                pattern: "Home/Index",
                defaults: new { controller = "Controller", action = "Index" }
            );
        }
    }
}
