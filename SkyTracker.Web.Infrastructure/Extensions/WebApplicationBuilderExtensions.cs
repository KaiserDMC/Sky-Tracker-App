namespace SkyTracker.Web.Infrastructure.Extensions;

using System.Reflection;

using Data.Models;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using static Common.UserRoleNames;

/// <summary>
/// Application extensions: Adding Services and Seeder for Admin and Moderator roles
/// </summary>

public static class WebApplicationBuilderExtensions
{
    // Gets all IService from the assembly and adds them (AddScoped)
    public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
    {
        Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);
        if (serviceAssembly == null)
        {
            throw new InvalidOperationException("Invalid service type provided!");
        }

        Type[] sType = serviceAssembly
            .GetTypes()
            .Where(st => st.Name.EndsWith("Service") && !st.IsInterface)
            .ToArray();

        foreach (Type st in sType)
        {
            var interfaceType = st
                .GetInterface($"I{st.Name}");

            if (interfaceType == null)
            {
                throw new InvalidOperationException($"No interface is provided for the service with name {st.Name}");
            }

            services.AddScoped(interfaceType, st);
        }
    }

    // Seeds the Admin role to the created Admin user in the DbContext
    public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string email)
    {
        using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

        IServiceProvider serviceProvider = scopedServices.ServiceProvider;

        UserManager<ApplicationUser> userManager =
            serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        RoleManager<IdentityRole<Guid>> roleManager =
            serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

        Task.Run(async () =>
            {
                if (!await roleManager.RoleExistsAsync(AdminRole))
                {
                    IdentityRole<Guid> role = new IdentityRole<Guid>(AdminRole);

                    await roleManager.CreateAsync(role);
                }

                ApplicationUser adminUser = await userManager.FindByEmailAsync(email);

                if (adminUser != null && !userManager.IsInRoleAsync(adminUser, AdminRole).GetAwaiter().GetResult())
                {
                    var newSecurityStamp = await userManager.UpdateSecurityStampAsync(adminUser);

                    await userManager.AddToRoleAsync(adminUser, AdminRole);
                }

            })
            .GetAwaiter()
            .GetResult();

        return app;
    }

    // Seeds the Moderator role to the created Moderator user in the DbContext
    public static IApplicationBuilder SeedModerator(this IApplicationBuilder app, string email)
    {
        using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

        IServiceProvider serviceProvider = scopedServices.ServiceProvider;

        UserManager<ApplicationUser> userManager =
            serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        RoleManager<IdentityRole<Guid>> roleManager =
            serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

        Task.Run(async () =>
            {
                if (!await roleManager.RoleExistsAsync(ModeratorRole))
                {
                    IdentityRole<Guid> role = new IdentityRole<Guid>(ModeratorRole);

                    await roleManager.CreateAsync(role);
                }

                ApplicationUser moderatorUser = await userManager.FindByEmailAsync(email);

                if (moderatorUser != null && !userManager.IsInRoleAsync(moderatorUser, ModeratorRole).GetAwaiter().GetResult())
                {
                    var newSecurityStamp = await userManager.UpdateSecurityStampAsync(moderatorUser);

                    await userManager.AddToRoleAsync(moderatorUser, ModeratorRole);
                }

            })
            .GetAwaiter()
            .GetResult();

        return app;
    }
}