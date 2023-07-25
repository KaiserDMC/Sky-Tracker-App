namespace SkyTracker.Web;

using Azure.Identity;
using Azure.Storage.Blobs;

using Data;
using Data.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Infrastructure.Extensions;
using SkyTracker.Services.Data.Interfaces;

using static Common.GeneralApplicationContants;
using SkyTracker.Web.Configuration;
using SkyTracker.Services.Data;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        builder.Services.AddDbContext<SkyTrackerDbContext>(options =>
            options.UseSqlServer(connectionString));

        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Idetity:SignIn:RequireConfirmedAccount");
            options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Idetity:Password:RequireLowercase");
            options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Idetity:Password:RequireUppercase");
            options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Idetity:Password:RequireNonAlphanumeric");
            options.Password.RequireDigit = builder.Configuration.GetValue<bool>("Idetity:Password:RequireDigit");
        })
            .AddRoles<IdentityRole<Guid>>()
            .AddEntityFrameworkStores<SkyTrackerDbContext>();
        builder.Services.AddControllersWithViews();

        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(corsPolicyBuilder =>
            {
                corsPolicyBuilder
                    .WithMethods("GET", "POST", "PUT", "DELETE")
                    .WithOrigins("https://maps.googleapis.com", "https://skytrackerwebstorage.blob.core.windows.net")
                    .AllowAnyHeader();
            });
        });

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/User/Login";
            options.LogoutPath = "/User/Logout";
        });
        
        // Add application services.
        //builder.Services.AddApplicationServices(typeof(IHeraldService));
        builder.Services.AddScoped<IHeraldService, HeraldService>();
        builder.Services.AddScoped<IAircraftService, AircraftService>();
        builder.Services.AddScoped<IAirportsService, AirportsService>();
        builder.Services.AddScoped<IFlightService, FlightService>();
        builder.Services.AddScoped<IRadarService, RadarService>();
        builder.Services.AddScoped<IAdminService, AdminService>();
        builder.Services.AddScoped<IUserManagementService, UserManagementService>();
        builder.Services.AddScoped<IHomeService, HomeService>();

        var blobServiceClient = new BlobServiceClient(
            new Uri("https://skytrackerwebstorage.blob.core.windows.net"),
            new DefaultAzureCredential());

        builder.Services.AddSingleton(blobServiceClient);

        var app = builder.Build();

        await GetImageData.GetImageDataFromAzureAsync(blobServiceClient, app.Environment);

        ImageHelper.Initialize(blobServiceClient);

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Test"))
        {
            app.UseMigrationsEndPoint();
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseCors();

        app.UseAuthentication();
        app.UseAuthorization();

        // Give administrator and moderator role to previously seeded users.
        if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Test"))
        {
            app.SeedAdministrator(DevAndTestingAdminEmail);
            app.SeedModerator(DevAndTestingModeratorEmail);
        }

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        app.Run();
    }
}