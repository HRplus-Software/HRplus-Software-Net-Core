using Microsoft.AspNetCore.Identity;
using WebApp.Areas.Identity.Data;
using WebApp.Constants;

namespace WebApp.DefaultData
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<HRplusUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(WebAppRoles.SuperAdministrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(WebAppRoles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(WebAppRoles.Employee.ToString()));
        }
    }
}
