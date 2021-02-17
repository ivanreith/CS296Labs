using System;
using Xunit;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using IvanCastronuno.Models;
using IvanCastronuno.Repositories;
using IvanCastronuno.Controllers;
using Microsoft.AspNetCore.Identity;

namespace IvanCastronunoTests
{
    public class StoriesRepoTest
    {
        StoryContext Context { get; set; }
        UserManager<AppUser> userManager;
        
        [Fact]
        public void AddStoryTest()
        {
            //Arrange
            var c = new StoryContext();
           
            var fakeRepo = new FakeStoriesRepository();
            var controller = new StoryController(fakeRepo, c, userManager);
            var Story = new StoriesModelForm()
            {
                StoryID = 0,
                StoryTitle = "Mannly" ,
               StoryTopic = "FAKE REPO TEST",
               StoryText = "more for testing the repo fake",
               Poster = new AppUser() {Name = "Testing user99"},

             };
            //Act
            controller.Edit(Story);

            // Assert Checking that story was added.
            var retrievedStory = fakeRepo.stories.ToList()[0];
            Assert.NotNull(retrievedStory.StoryText);

        }

        [Fact]
        public void RemoveStoryTest()
        {
            //Arrange
            var c = new StoryContext();
            var fakeRepo = new FakeStoriesRepository();
            var controller = new StoryController(fakeRepo,c, userManager);
            var Story = new StoriesModelForm()
            {
                StoryID = 0,
                StoryTitle = "Mannly",
                StoryTopic = "FAKE REPO TEST",
                StoryText = "more for testing the repo fake",
                Poster = new AppUser() {Name = "Testing user99" },

            };
            //Act
            controller.Edit(Story); // That's for add to the repo fake
            controller.Delete(Story);// That's for erasing the just added Story

            // Assert Checking that the repo fake is empty           
            Assert.Empty(fakeRepo.stories);

        }

        [Fact]
        public void UpdateStoryTest()
        {
            //Arrange
            var c = new StoryContext();
            var fakeRepo = new FakeStoriesRepository();
            var controller = new StoryController(fakeRepo, c, userManager);
            var Story = new StoriesModelForm()
            {
                StoryID = 0,
                StoryTitle = "Mannly",
                StoryTopic = "FAKE REPO TEST",
                StoryText = "more for testing the repo fake",
                Poster = new AppUser() {Name = "Testing user99" },

            };
            var Story2 = new StoriesModelForm()
            {
                StoryID = 1, // same ID so the controller overrides
                StoryTitle = "Test2",
                StoryTopic = "FAKE REPO TEST2",
                StoryText = "more for testing the repo fake",
                Poster = new AppUser() {Name = "Testing user99" },

            };
            var Story3 = new StoriesModelForm()
            {
                StoryID = 1, // same ID so the controller overrides
                StoryTitle = "Test3",
                StoryTopic = "FAKE REPO TEST3",
                StoryText = "more for testing the repo fake",
                Poster = new AppUser() {Name = "Testing user99" },

            };
            //Act
            controller.Edit(Story);// This adds the first Story to the repo
            //Story = Story2;// puts Story2 onto Story
            controller.Edit(Story2);// This adds the Second Story to the repo
            //Story2 = Story3;
            controller.Edit(Story3);
            // Assert Checking that story was added.
            StoriesModelForm retrievedStory = fakeRepo.stories.ToList()[0];
            Assert.Equal("FAKE REPO TEST3", retrievedStory.StoryTopic);
           
        }
        [Fact]
        public void ReadStoryByIdTest()
        {
            //Arrange
            var c = new StoryContext();
            var fakeRepo = new FakeStoriesRepository();
            var controller = new StoryController(fakeRepo, c , userManager);
            var Story = new StoriesModelForm()
            {
                StoryID = 0,
                StoryTitle = "Mannly",
                StoryTopic = "FAKE REPO TEST",
                StoryText = "more for testing the repo fake",
                Poster = new AppUser() {Name = "Testing user99" },

            };
            //Act
            controller.Edit(Story); //saves it

            // Assert Checking that It can be accessed
            var retrievedStory = fakeRepo.GetStoryById(0);
            Assert.NotNull(retrievedStory.StoryText);

        }



    }
}
