using HolocronProject.Data.Models;
using HolocronProject.Services;
using Microsoft.AspNetCore.Identity;

namespace HolocronProject.Web.Seeder
{
    public class DataSeeder
    {
        public static void SeedData(UserManager<Account> userManager,
            RoleManager<IdentityRole> roleManager,
            IAccountsService accountsService)
        {
            
            SeedRoles(roleManager);
            SeedUsers(userManager, accountsService);
        }

        public static void SeedUsers(UserManager<Account> userManager, IAccountsService accountsService)
        {
            if (userManager.FindByNameAsync("TestUser1").Result == null)
            {
                var testUser = new Account
                {
                    UserName = "TestUser1",
                    EmailConfirmed = true,
                    Email = "testUser@gmail.com"
                };

                var result = userManager.CreateAsync(testUser, "TestUser1.").Result;
                
                if (result.Succeeded)
                {
                    accountsService.AddDefaultAvatarImagePathAsync(testUser.Id).Wait();
                    userManager.AddToRoleAsync(testUser, "Account").Wait();
                }
            }

            if (userManager.FindByNameAsync("TestAdmin1").Result == null)
            {
                var testAdmin = new Account
                {
                    UserName = "TestAdmin1",
                    EmailConfirmed = true,
                    Email = "testAdmin@gmail.com"
                };

                var result = userManager.CreateAsync(testAdmin, "TestAdmin1.").Result;

                if (result.Succeeded)
                {
                    accountsService.AddDefaultAvatarImagePathAsync(testAdmin.Id).Wait();
                    userManager.AddToRoleAsync(testAdmin, "Admin").Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Account").Result)
            {
                var roleUser = new IdentityRole() { Name = "Account" };
                roleManager.CreateAsync(roleUser).Wait();
            }

            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var roleAdmin = new IdentityRole() { Name = "Admin" };
                roleManager.CreateAsync(roleAdmin).Wait();
            }
        }
    }
}
