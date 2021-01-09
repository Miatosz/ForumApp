using ForumApp.Data;
using ForumApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ForumApp
{
    public class Startup
    {
        public IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddMvc(opt => opt.EnableEndpointRouting = false);
            
            services.AddDbContext<ForumDbContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("ForumConnectionString")
            ));

            services.AddTransient<ICategoryRepo, CategoryRepo>();
            services.AddTransient<IUserRepo, UserRepo>();
            services.AddTransient<IPostRepo, PostRepo>();
            
        }
        

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

             app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: null,
                    template: "",
                    defaults : new {controller="Category", action="Index"}
                );
                routes.MapRoute(
                    name: null,
                    template: "{controller}/{action}"                    
                );

                routes.MapRoute(
                    name: null,
                    template: "{controller}/{action}/{method}"
                );

                routes.MapRoute(
                    name: null,
                    template: "{controller}",
                    defaults: new {action="Index"}
                );

                
            });

           
        }
    }
}
