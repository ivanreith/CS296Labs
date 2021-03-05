 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IvanCastronuno.Models;

namespace IvanCastronuno.Repositories
{
    public interface IStories
    {
        IQueryable<StoriesModelForm> stories { get; } // read   or get    
       // object Poster { get; }

        void AddStory(StoriesModelForm stories);  // create
        StoriesModelForm GetStoryById(int StoryId); //Retrieve a story by topic
        void UpdateStory(StoriesModelForm stories);
        void DeleteStory(StoriesModelForm stories);
        List<CommentModel> GetCommentsByStory(int Id);
        List<CommentModel> GetComments();
        CommentModel GetCommentById(int Id);
    }
}
