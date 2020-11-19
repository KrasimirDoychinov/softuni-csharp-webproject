using HolocronProject.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web
{
    public class MyIdentityDataInitializer
    {
        public static void SeedData(UserManager<Account> userManager,RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<Account> userManager)
        {
            if (userManager.FindByNameAsync("TestUser1").Result == null)
            {
                var testUser = new Account
                {
                    UserName = "TestUser1",
                };

                var result = userManager.CreateAsync(testUser, "TestUser1.").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(testUser, "Account").Wait();
                }
            }

            if (userManager.FindByNameAsync("AdminUser1").Result == null)
            {
                var testAdmin = new Account
                {
                    UserName = "TestAdmin1"
                };

                var result = userManager.CreateAsync(testAdmin, "TestAdmin1.").Result;

                if (result.Succeeded)
                {
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
