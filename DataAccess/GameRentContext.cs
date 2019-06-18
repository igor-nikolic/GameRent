using DataAccess.Configurations;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DataAccess
{
    public class GameRentContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FJ93TN6\SQLEXPRESS;Initial Catalog=RentGame;Integrated Security=True");
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FJ93TN6\SQLEXPRESS;Initial Catalog=GameRent;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new RentConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            
            //Company seeding
            modelBuilder.Entity<Company>().HasData(
                new Company{Id = 1,Name = "Ubisoft"}, 
                new Company{Id = 2,Name = "Electronic Arts"}, 
                new Company{Id = 3,Name = "Nintendo"}, 
                new Company{Id = 4,Name = "Sony"}, 
                new Company{Id = 5,Name = "Rockstar Games"} 
                );
            // Categories seeding
            modelBuilder.Entity<Category>().HasData(
                new Category{Id = 1,Name = "Massively Multiplayer Online"}, 
                new Category{Id = 2,Name = "Simulations"}, 
                new Category{Id = 3,Name = "Adventure"}, 
                new Category{Id = 4,Name = "Real-Time Strategy"}, 
                new Category{Id = 5,Name = "Puzzle"}, 
                new Category{Id = 6,Name = "Action"}, 
                new Category{Id = 7,Name = "Stealth Shooter"}, 
                new Category{Id = 8,Name = "Combat"}, 
                new Category{Id = 9,Name = "First Person Shooters"}, 
                new Category{Id = 10,Name = "Sports"}, 
                new Category{Id = 11,Name = "Role-Playing"}, 
                new Category{Id = 12,Name = "Educational"} 
                );
            //Roles seeding
            modelBuilder.Entity<Role>().HasData(
                new Role{Id = 1,Name = "Admin"},
                new Role{Id = 2,Name = "User"}
            );
            //Users seeding
            modelBuilder.Entity<User>().HasData(
                new User{Id = 1,FirstName = "Admin",LastName = "Admin",Email = "examleadmin@example.com",Password = "admin",RoleId = 1}, //change this
                new User{Id = 2,FirstName = "User",LastName = "User",Email = "examleuser@example.com",Password = "user",RoleId = 2}
            );
            //Games seeding
            modelBuilder.Entity<Game>().HasData(
                new Game{Id = 1,Name = "Need for Speed",Description = "Racing game",CategoryId = 2,CompanyId = 2},
                new Game{Id = 2,Name = "Mario Kart",Description = "Childhood game",CategoryId = 3,CompanyId = 4},
                new Game{Id = 3,Name = "Assassin Creed",Description = "This is a description for assassins game",CategoryId = 8,CompanyId = 1},
                new Game{Id = 4,Name = "Tom Clancy",Description = "This is a description for Tom Clancy",CategoryId = 9,CompanyId = 1},
                new Game{Id = 5,Name = "Prince of Persia",Description = "This is a description for Prince of Persia",CategoryId = 7,CompanyId = 1},
                new Game{Id = 6,Name = "Far Cry",Description = "This is a description for Far Cry",CategoryId = 1,CompanyId = 1},
                new Game{Id = 7,Name = "FIFA 19",Description = "This is a description for FIFA 19",CategoryId = 10,CompanyId = 2},
                new Game{Id = 8,Name = "The Sims 4",Description = "This is a description for The Sims 4",CategoryId = 4,CompanyId = 2},
                new Game{Id = 9,Name = "Grand Theft Auto",Description = "This is a description for Grand Theft Auto",CategoryId = 12,CompanyId = 5},
                new Game{Id = 10,Name = "Mario Bros",Description = "This is a description for Mario Bros",CategoryId = 8,CompanyId = 3}
            );


        }


    }
}
