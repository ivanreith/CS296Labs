using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IvanCastronuno.Models
{
    public class StoryContext : IdentityDbContext
    {
        public StoryContext()
        {
        }

        public StoryContext(DbContextOptions<StoryContext> options)
            : base(options)
        { }

        public DbSet<StoriesModelForm> Story { get; set; }
        public DbSet<AppUser> AppUser { get; set; } //REmoved due to Identity inheritance, parent class would do it

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);//  Internet suggestion to solve some problem.
            modelBuilder.Entity<AppUser>().HasData(
                 new AppUser {Name = "Johnny" },// Removed for identity reason , parent  class has this =>  UserId = "1", etc
                 new AppUser {Name = "Tommy" },
                 new AppUser {Name = "Danny" },
                 new AppUser {Name = "Mannly" },
                 new AppUser {Name = "Conny" },
                 new AppUser {Name = "Sunny" },
                 new AppUser {Name = "Diandra" }
             );
          
            modelBuilder.Entity<StoriesModelForm>().HasData(
                new StoriesModelForm
                {
                    StoryID = 1,
                    StoryTitle = "Viaje",
                    StoryTopic = "Travel",
                    StoryText = "To do a travel wearing armor isn't fun",
                    Name = "Johnny", // that is the userId for the identity user model
                    StoryTime = DateTime.Today
                },
                new StoriesModelForm
                {
                    StoryID = 2,
                    StoryTitle = "Crafting",
                    StoryTopic = "Use instructions",
                    StoryText = "To redo your costume three times for not follow the instructions is a common noob mistake.",
                    Name = "Mannly", // that is the userId for the identity user model
                    StoryTime = DateTime.Today

                },
                new StoriesModelForm
                {
                    StoryID = 3,
                    StoryTitle = "Food",
                    StoryTopic = "Find friends",
                    StoryText = "When on a recreation , if u have food , you'll find friends",
                    Name = "Diandra",// that is the userId for the identity user model
                    StoryTime = DateTime.Today

                }
            ) ;
        }
    }
}