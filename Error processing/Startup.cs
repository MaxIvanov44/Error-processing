using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Error_processing
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // обработка ошибок HTTP
            //app.UseStatusCodePagesWithReExecute("/error", "?code={0}");

            //app.Map("/error", ap => ap.Run(async context =>
            //{
            //    await context.Response.WriteAsync($"Err: {context.Request.Query["code"]}");
            //}));

            //app.Map("/hello", ap => ap.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello ASP");
            //}));

            app.Map("/hello", ap => ap.Run(async (context) =>
            {
                await context.Response.WriteAsync("HEllo ASP");
            }));
        }
    }
}