using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;

namespace IvanCastronuno.Models
{
    public class StoryContext : DbContext
    {
        public StoryContext()
        {
        }

        public StoryContext(DbContextOptions<StoryContext> options)
            : base(options)
        { }

        public DbSet<StoriesModelForm> Stories { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                 new User { UserId = "1", UserName = "Johnny" },
                 new User { UserId = "2", UserName = "Tommy" },
                 new User { UserId = "3", UserName = "Danny" },
                 new User { UserId = "4", UserName = "Mannly" },
                 new User { UserId = "5", UserName = "Conny" },
                 new User { UserId = "6", UserName = "Sunny" },
                 new User { UserId = "7", UserName = "Diandra" }
             );

            modelBuilder.Entity<StoriesModelForm>().HasData(
                new StoriesModelForm
                {
                    StoryID = 1,
                    StoryTitle = "Viaje",
                    StoryTopic = "Travel",
                    StoryText = "To do a travel wearing armor isn't fun",
                    UserId = "1",
                 
                },
                new StoriesModelForm
                {
                    StoryID = 2,
                    StoryTitle = "Crafting",
                    StoryTopic = "Use instructions",
                    StoryText = "To redo your costume three times for not follow the instructions is a common noob mistake.",
                    UserId = "6",
                   
                },
                new StoriesModelForm
                {
                    StoryID = 3,
                    StoryTitle = "Food",
                    StoryTopic = "Find friends",
                    StoryText = "When on a recreation , if u have food , you'll find friends",
                    UserId = "7",
                   
                }
            );
        }
    }
}