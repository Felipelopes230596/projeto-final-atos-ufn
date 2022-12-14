using Microsoft.EntityFrameworkCore;
using projeto_final.Repositorio;

namespace projeto_final
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration= configuration;
        }

        public IConfiguration Configuration { get;}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddEntityFrameworkSqlServer().AddDbContext<Contexto>(o => o.UseSqlServer(Configuration.GetConnectionString("DataBase")));
            services.AddScoped<IUtilRepositorio, UtilRepositorio>();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        }
    }
}
