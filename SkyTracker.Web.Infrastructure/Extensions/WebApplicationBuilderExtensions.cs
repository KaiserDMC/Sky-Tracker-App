namespace SkyTracker.Web.Infrastructure.Extensions;

using System.Reflection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using Data.Models;
using static Common.UserRoleNames;

public static class WebApplicationBuilderExtensions
{
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