using System;
using DustysCorner.DAL;
using DustysCorner.DAL.Initializers;
using DustysCorner.DAL.Repos;
using DustysCorner.DAL.Repos.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace DustysCorner.Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup JSON serialization options.
            services.AddMvc().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Formatting = Formatting.Indented;
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            // Allow Cors for any origin.
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://www.dustyscorner.com",
                                        "https://www.dustyscorner.com",
                                        "https://localhost:54175")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod();
                });
            });


            // Add DAL repository services.
            services.AddDbContext<StoreContext>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<IEventRepo, EventRepo>();
            services.AddScoped<IReviewRepo, ReviewRepo>();
            services.AddScoped<IGalleryRepo, GalleryRepo>();
            services.AddScoped<ISocialMediaRepo, SocialMediaRepo>();
            services.AddScoped<IFeaturedProductRepo, FeaturedProductRepo>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                // Seed database.
                StoreDataInitializer.InitializeData(serviceProvider);
                
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(MyAllowSpecificOrigins);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
