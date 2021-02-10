using IvanCastronuno.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

//, StoriesRepository r  //      repo = r;

namespace IvanCastronuno.Repositories
{
    public class StoriesRepository : IStories
    {
        //StoriesRepository repo;
         StoryContext context;
        // constructor for the BD context
        public StoriesRepository(StoryContext c)
        { 
                context = c;
          
        }


        public IQueryable<StoriesModelForm> stories
        {
            get 
            {
                return context.Story.Include(stories => stories.Poster)
                                    .Include(stories => stories.Comments )
                                    .ThenInclude(comment => comment.Commenter);
            }
        }
        
        public void AddStory(StoriesModelForm story)
        {
            story.StoryTime = DateTime.Now;
             // TODO add the actual logged in user example string userName = User.Identity.Name
            context.Story.Add(story);
            context.SaveChanges();
        }

        public void DeleteStory(StoriesModelForm story)
        {
            context.Story.Remove(story);
            context.SaveChanges();
        }

        public StoriesModelForm GetStoryById(int StoryId)
        {
            //throw new NotImplementedException();
            var story = context.Story.Find(StoryId);
            return story;
        }

        public void UpdateStory(StoriesModelForm story)
        {

            context.Story.Update(story);
            context.SaveChanges();
        }
    }
}
