using System;
using System.Collections.Generic;
using Influentia.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Influentia.DAL.Data
{
    public partial class DefaultContext : DbContext
    {
        public DefaultContext()
        {
        }

        public DbSet<SocialAccountTracker> SocialAcountTracker { get; set; }
        public DbSet<SocialAccountTypes> SocialAccountTypes { get; set; }
        public DbSet<UserSocialAccounts> UserSocialAccounts { get; set; }


        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            SeedSocialAccountTypes(modelBuilder);
        }

        private static void SeedSocialAccountTypes(ModelBuilder modelBuilder)
        {
            List<SocialAccountTypes> socialAccountType = new List<SocialAccountTypes>()
            {
                new SocialAccountTypes() { Id = 1, AccountType = "Facebook" },
                new SocialAccountTypes() { Id = 2, AccountType = "Instagram" },
                new SocialAccountTypes() { Id = 3, AccountType = "Twitter" },
                new SocialAccountTypes() { Id = 4, AccountType = "Youtube" },
                new SocialAccountTypes() { Id = 5, AccountType = "LinkedIn" },
            };

            modelBuilder.Entity<SocialAccountTypes>().HasData(socialAccountType);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
