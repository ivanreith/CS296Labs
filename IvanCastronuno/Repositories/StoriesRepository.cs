using IvanCastronuno.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
              return context.Story.Include(stories => stories.Poster);
            }
        }

        public void AddStory(StoriesModelForm story)
        {
            story.StoryTime = DateTime.Now;
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
            story.StoryTime = DateTime.Now;
            context.Story.Update(story);
            context.SaveChanges();
        }
    }
}
