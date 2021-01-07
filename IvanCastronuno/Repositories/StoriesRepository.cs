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
              return context.Stories.Include(stories => stories.Poster);
            }
        }

        public void AddStory(StoriesModelForm stories)
        {
            context.Stories.Add(stories);
            context.SaveChanges();
        }

        public void DeleteStory(StoriesModelForm stories)
        {
            context.Stories.Remove(stories);
            context.SaveChanges();
        }

        public StoriesModelForm GetStoryById(int StoryId)
        {
            //throw new NotImplementedException();
            var story = context.Stories.Find(StoryId);
            return story;
        }

        public void UpdateStory(StoriesModelForm stories)
        {
            context.Stories.Update(stories);
            context.SaveChanges();
        }
    }
}
