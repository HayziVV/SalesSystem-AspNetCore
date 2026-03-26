using Microsoft.EntityFrameworkCore;
using SalesWebMVCProject.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using SalesWebMVCProject.Services;

namespace SalesWebMVCProject;

public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("SalesWebMVCProjectContext")
            ?? throw new InvalidOperationException("Connection string 'SalesWebMVCProjectContext' not found.");

        builder.Services.AddDbContext<SalesWebMVCProjectContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        // Add services to the container.
        builder.Services.AddScoped<SeedingService>();
        builder.Services.AddScoped<SellerService>();
        builder.Services.AddScoped<DepartmentService>();
        builder.Services.AddScoped<SalesRecordService>();
        builder.Services.AddControllersWithViews();
        
        var app = builder.Build();

        var enUS = new CultureInfo("en-US");
        var localizationOptions = new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture(enUS),
            SupportedCultures = new List<CultureInfo> { enUS },
            SupportedUICultures = new List<CultureInfo> { enUS }
        };
        app.UseRequestLocalization(localizationOptions);

        if (app.Environment.IsDevelopment())
        {
            using (var scope = app.Services.CreateScope())
            {
                var seedingServices = scope.ServiceProvider.GetRequiredService<SeedingService>();
                seedingServices.Seed();
            }
        }
        // Configure the HTTP request pipeline.
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();

        app.Run();
    }
}
