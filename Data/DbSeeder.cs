using FinalAECApp.Constants;
using Microsoft.AspNetCore.Identity;

namespace FinalAECApp.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            //Seed Roles
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Employee.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Farmer.ToString()));

            // creating employee

            var user = new ApplicationUser
            {
                Name = "Patricia",
                Surname = "Jordaan",
                UserName = "employee@gmail.com",
                Email = "employee@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var userInDb = await userManager.FindByEmailAsync(user.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(user, "Employee@123");
                await userManager.AddToRoleAsync(user, Roles.Employee.ToString());
            }
        }
    }
}
