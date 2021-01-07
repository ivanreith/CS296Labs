using IvanCastronuno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using IvanCastronuno.Repositories;
namespace IvanCastronuno.Repositories
{
    public class FakeStoriesRepository : IStories
    {
        
        //public IQueryable<StoriesModelForm> stories => throw new NotImplementedException();
        List<StoriesModelForm> Stories = new List<StoriesModelForm>();
        public IQueryable<StoriesModelForm> stories { get { return Stories.AsQueryable(); } }
        // public IQueryable<StoriesModelForm> Stories => Stories;

        // public IQueryable<StoriesModelForm> Story  { get { return (IQueryable<StoriesModelForm>)stories; }}

        public void AddStory(StoriesModelForm stories)
        {
            stories.StoryID = Stories.Count() ;
            Stories.Add(stories);


        }

        public void DeleteStory(StoriesModelForm stories)
        {
          Stories.Remove(stories);
        }

        public StoriesModelForm GetStoryById(int Id)
        {
          foreach(StoriesModelForm Story in Stories)
            {
                if (Story.StoryID == Id)
                {
                    return Story;
                }
               
            }
         return null;
            // throw new NotImplementedException();
            //  StoriesModelForm storyRecovered = Stories.Find(Id) ;  // This one gave me an type missmatch error
            //            return storyRecovered;
        }

        public void UpdateStory(StoriesModelForm stories)
        {
            Stories[0] = stories; // it takes one out because the count starts at 0 with 1 element
        }
    }
}
