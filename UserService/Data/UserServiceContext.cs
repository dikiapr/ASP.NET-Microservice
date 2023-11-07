using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Entities;

namespace UserService.Data
{
    public class UserServiceContext : DbContext
    {
        public UserServiceContext(DbContextOptions<UserServiceContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<IntegrationEvent> IntegrationEventOutbox { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed User Table
            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 1,
                Name = "John",
                Mail = "Hastings",
                OtherData = "John@pragimtech.com",
                Version = 0
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 2,
                Name = "Roxy",
                Mail = "Erron",
                OtherData = "Roxy@pragimtech.com",
                Version = 0
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 3,
                Name = "Firo",
                Mail = "Heios",
                OtherData = "firo@pragimtech.com",
                Version = 0
            });


        }
    }
}
