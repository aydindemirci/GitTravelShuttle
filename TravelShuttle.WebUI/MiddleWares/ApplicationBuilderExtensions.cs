using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace TravelShuttle.WebUI.MiddleWares
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseStaticFilePath(this IApplicationBuilder app, string root, string[] pathList)
        {
            foreach (var path in pathList)
            {
                var options = new StaticFileOptions();

                options.RequestPath = "/"+path;
                options.FileProvider = new PhysicalFileProvider(Path.Combine(root, path));

                app.UseStaticFiles(options);
            }
            return app;
        }
    }
}
