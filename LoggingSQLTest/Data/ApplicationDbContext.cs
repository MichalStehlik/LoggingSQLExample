using LoggingSQLTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingSQLTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(new Game { Id = 1, Name = "Witcher: Wild Hunt" });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 2, Name = "Cyberpunk 2077" });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 3, Name = "Doom" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 1, Text = "RPG", GameId = 1 });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 2, Text = "Fantasy", GameId = 1 });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 3, Text = "Action", GameId = 1 });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 4, Text = "RPG", GameId = 2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 5, Text = "Cyberpunk", GameId = 2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 6, Text = "Action", GameId = 2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 7, Text = "Shooter", GameId = 3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 8, Text = "Action", GameId = 3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 9, Text = "Sci-fi", GameId = 3 });
        }
    }
}
