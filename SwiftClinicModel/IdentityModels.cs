﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SwiftClinicModel;

namespace BinghamWebApp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

    
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PreliminaryExamination> PreliminaryExaminations { get; set; }
        public DbSet<ConsultantRecord> ConsultantRecords { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<AccountType> AccountTypes { get; set; }

        public DbSet<Referral> Referrals { get; set; }
        public DbSet<Pescription> Pescriptions { get; set; }
    }
}