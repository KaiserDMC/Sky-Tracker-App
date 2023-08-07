namespace SkyTracker.Web;

using Azure.Identity;
using Azure.Storage.Blobs;

using Configuration;

using Data;
using Data.Models;

using Infrastructure.Extensions;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using SkyTracker.Services.Data.Interfaces;
using SkyTracker.Web.Areas.Admin.Services.Interfaces;

using static Common.GeneralApplicationContants;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Connection string for SQL Database.
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        builder.Services.AddDbContext<SkyTrackerDbContext>(options =>
            options.UseSqlServer(connectionString));

        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        // Password requirements for Identity.
        // Take from appsettings.json.
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

        // Configure CORS policy.
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
            options.AccessDeniedPath = "/Home/Error/401";
        });

        // Add application services.
        builder.Services.AddApplicationServices(typeof(IHomeService));
        builder.Services.AddApplicationServices(typeof(IAdminService));

        // Add Azure Blob Storage.
        var blobServiceClient = new BlobServiceClient(
            new Uri("https://skytrackerwebstorage.blob.core.windows.net"),
            new DefaultAzureCredential());

        builder.Services.AddSingleton(blobServiceClient);

        var app = builder.Build();

        // Get image data from Azure Blob Storage.
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
            app.UseExceptionHandler("/Home/Error/500");
            app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");
            
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

        // Add Admin area routing.
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "areaRoute",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });

        app.MapRazorPages();

        await app.RunAsync();
    }
}