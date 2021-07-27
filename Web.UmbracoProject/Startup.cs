using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Extensions;

namespace Web.UmbracoProject
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="webHostEnvironment">The Web Host Environment</param>
        /// <param name="config">The Configuration</param>
        /// <remarks>
        /// Only a few services are possible to be injected here https://github.com/dotnet/aspnetcore/issues/9337
        /// </remarks>
        public Startup(IWebHostEnvironment webHostEnvironment, IConfiguration config)
        {
            _env = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }



        /// <summary>
        /// Configures the services
        /// </summary>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </remarks>
        public void ConfigureServices(IServiceCollection services)
        {
#pragma warning disable IDE0022 // Use expression body for methods
            services.AddUmbraco(_env, _config)
                .AddBackOffice()
                .AddWebsite()
                .AddComposers()
                .Build();
#pragma warning restore IDE0022 // Use expression body for methods

            // LigerShark.WebOptimizer.Core 
            services.AddWebOptimizer(pipeline =>
            {
                pipeline.AddCssBundle(
                    "/css/bundle.css", "/css/vendor/bootstrap/css/bootstrap.min.css",
                    "/css/vendor/icofont/icofont.min.css", "/css/vendor/boxicons/css/boxicons.min.css",
                    "/css/vendor/animate.css/animate.min.css", "/css/vendor/owl.carousel/assets/owl.carousel.min.css",
                    "/css/vendor/venobox/venobox.css");

                pipeline.AddJavaScriptBundle(
                   "/scripts/bundle.js", "/css/vendor/jquery/jquery.min.js", "/css/vendor/bootstrap/js/bootstrap.bundle.min.js",
                   "/css/vendor/jquery.easing/jquery.easing.min.js", "/css/vendor/php-email-form/validate.js",
                   "/css/vendor/jquery-sticky/jquery.sticky.js", "/css/vendor/owl.carousel/owl.carousel.min.js",
                   "/css/vendor/waypoints/jquery.waypoints.min.js", "/css/vendor/counterup/counterup.min.js", "/css/vendor/isotope-layout/isotope.pkgd.min.js",
                   "/css/vendor/venobox/venobox.min.js");
            });
        } 

        /// <summary>
        /// Configures the application
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // LigerShark.WebOptimizer.Core 
            app.UseWebOptimizer();

            app.UseUmbraco()
                .WithMiddleware(u =>
                {
                    u.WithBackOffice();
                    u.WithWebsite();
                })
                .WithEndpoints(u =>
                {
                    u.UseInstallerEndpoints();
                    u.UseBackOfficeEndpoints();
                    u.UseWebsiteEndpoints();
                });
        }
    }
}
