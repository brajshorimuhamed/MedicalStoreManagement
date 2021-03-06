using MedicalStoreManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MedicalStoreManagement.Infrastructure
{
    public class MedicalStoreDbInitializer
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            new MedicalStoreDbInitializer().SeedData(modelBuilder);
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            SeedRoles(modelBuilder);
            SeedUsers(modelBuilder);
            SeedUserRoles(modelBuilder);
        }

        private void SeedUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "23BC3895-B661-6987-87A7-85A732C7E7B5",
                    UserId = "8A7EA655-6149-6CD5-BD56-DA253DD53FF7"
                });
        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = "23BC3895-B661-6987-87A7-85A732C7E7B5",
                    Name = "SuperAdmin",
                    NormalizedName = "SuperAdmin"
                },
                new Role
                {
                    Id = "5FFB5456-CA2C-6161-AB2F-4AE3BE6E57D6",
                    Name = "Employee",
                    NormalizedName = "Employee"
                });
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            var user = new User
            {
                Id = "8A7EA655-6149-6CD5-BD56-DA253DD53FF7",
                Email = "muhamedbrajshori123@gmail.com",
                EmailConfirmed = true,
                NormalizedEmail = "muhamedbrajshori123@gmail.com",
                FirstName = "Muhamed",
                LastName = "Brajshori",
                PhoneNumber = "+38344225107",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = false,
                UserName = "muhamedbrajshori123@gmail.com",
                NormalizedUserName = "muhamedbrajshori123@gmail.com"
            };

            user.PasswordHash = new PasswordHasher<User>().HashPassword(user, "Meti@2021");

            modelBuilder.Entity<User>().HasData(user);

            SeedUserClaims(modelBuilder, user);
        }

        private void SeedUserClaims(ModelBuilder modelBuilder, User user)
        {
            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
                new IdentityUserClaim<string>
                {
                    ClaimType = ClaimTypes.NameIdentifier, 
                    Id = 1,
                    UserId = user.Id,
                    ClaimValue = user.Id
                },
                new IdentityUserClaim<string>
                {
                    ClaimType = ClaimTypes.Email,
                    Id = 2, 
                    UserId = user.Id,
                    ClaimValue = user.Email
                },
                new IdentityUserClaim<string>
                {
                    ClaimType = ClaimTypes.Role,
                    Id = 3,
                    UserId = user.Id,
                    ClaimValue = "Super Admin"
                },
                new IdentityUserClaim<string>
                {
                    ClaimType = ClaimTypes.MobilePhone,
                    Id = 4,
                    UserId = user.Id,
                    ClaimValue = user.PhoneNumber
                },
                new IdentityUserClaim<string>
                {
                    ClaimType = ClaimTypes.GivenName,
                    Id = 5,
                    UserId = user.Id,
                    ClaimValue = user.FirstName
                },
                new IdentityUserClaim<string>
                {
                    ClaimType = ClaimTypes.Surname,
                    Id = 6,
                    UserId = user.Id,
                    ClaimValue = user.LastName
                });
        }
    }
}
