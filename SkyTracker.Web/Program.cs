namespace SkyTracker.Web;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Azure.Storage.Blobs;
using Azure.Identity;

using Data;
using Data.Models;
using SkyTracker.Services.Data;
using SkyTracker.Services.Data.Interfaces;
using static Common.UserRoleNames;

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
            options.SignIn.RequireConfirmedAccount = false;
            options.Password.RequireDigit = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
        })
            .AddRoles<IdentityRole<Guid>>()
            .AddEntityFrameworkStores<SkyTrackerDbContext>();
        builder.Services.AddControllersWithViews();

        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder
                    .AllowAnyMethod()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
            });
        });

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/User/Login";
        });

        builder.Services.AddScoped<IHeraldService, HeraldService>();
        builder.Services.AddScoped<IAircraftService, AircraftService>();
        builder.Services.AddScoped<IAirportsService, AirportsService>();
        builder.Services.AddScoped<IFlightService, FlightService>();
        builder.Services.AddScoped<IAdminService, AdminService>();

        var blobServiceClient = new BlobServiceClient(
            new Uri("https://skytrackerwebstorage.blob.core.windows.net"),
            new DefaultAzureCredential());

        builder.Services.AddSingleton(blobServiceClient);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
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


        // Add Admin role to admin@test.bg and User role to user@test.bg
        // Default users that are created upon DB creation
        using (var scope = app.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            // Assign role to user if they don't have one
            var user = userManager.FindByEmailAsync("user@test.bg").GetAwaiter().GetResult();
            if (user != null && !userManager.IsInRoleAsync(user, UserRole).GetAwaiter().GetResult())
            {
                var newSecurityStamp = await userManager.UpdateSecurityStampAsync(user);
                userManager.AddToRoleAsync(user, UserRole).GetAwaiter().GetResult();
            }

            // Assign role to admin if they don't have one
            var adminUser = userManager.FindByEmailAsync("admin@test.bg").GetAwaiter().GetResult();
            if (adminUser != null && !userManager.IsInRoleAsync(adminUser, AdminRole).GetAwaiter().GetResult())
            {
                var newSecurityStamp = await userManager.UpdateSecurityStampAsync(adminUser);
                userManager.AddToRoleAsync(adminUser, AdminRole).GetAwaiter().GetResult();
            }
        }

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        app.Run();
    }
}