using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Neil",
                    Email = "neil@cummings.com",
                    UserName = "neil@cummings.com",
                    Address = new Address
                    {
                        FirstName = "Neil",
                        LastName = "Cummings",
                        Street = "10 Street",
                        City = "Manchester",
                        State = "LD",
                        ZipCode = "76200"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}