﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SwiftClinicModels;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SwiftClinic.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class SwiftClinicDbContext : IdentityDbContext<ApplicationUser>
    {
        public SwiftClinicDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Audit> AuditRecords { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        public static SwiftClinicDbContext Create()
        {
            return new SwiftClinicDbContext();
        }
    }
}