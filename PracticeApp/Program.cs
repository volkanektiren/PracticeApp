using DesignPatterns.Creational.AbstractFactory.Factories.Abstract;
using DesignPatterns.Creational.AbstractFactory.Factories.Concrete;
using DesignPatterns.Creational.FactoryMethod.Creators.Abstract;
using DesignPatterns.Creational.FactoryMethod.Creators.Concrete;
using Microsoft.EntityFrameworkCore;
using PracticeApp.Data;

namespace PracticeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add dbcontext to DI container
            builder.Services.AddDbContext<PracticeContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("PracticeDB")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IFactory, Factory1>();
            builder.Services.AddScoped<Creator, Creator2>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
