using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using projeto_final.Repositorio;
using FluentAssertions.Common;
using MongoDB.Driver.Core.Configuration;

namespace projeto_final
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var startup = new Startup(builder.Configuration);
            startup.ConfigureServices(builder.Services);                       

            var app = builder.Build();
                       
            startup.Configure(app, app.Environment);
            app.Run();
        }
    }
}