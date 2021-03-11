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
         
         var comments = context.Comments.ToList();
            foreach (CommentModel comment in comments) // added to delete all comments of a story before deleting the story
            {
                foreach (CommentModel storycomment in story.Comments)
                {
                    if (comment.CommentId == storycomment.CommentId)
                    {
                        context.Comments.Remove(comment);
                        context.SaveChanges();
                    }
                }
            }
            
               
                context.Story.Remove(story);
            context.SaveChanges();
        }
        public void DeleteComment(CommentModel comment)
        {
            context.Comments.Remove(comment);
            context.SaveChanges();
        }
        public StoriesModelForm GetStoryById(int StoryId)
        {

            var story = (from s in context.Story
                         where s.StoryID == StoryId
                         select s).FirstOrDefault<StoriesModelForm>();

           // var story = context.Story.Find(StoryId);
            return story;
        }

        public void UpdateStory(StoriesModelForm story)
        {

            context.Story.Update(story);
            context.SaveChanges();
        }
        public void UpdateComment(CommentModel comment)
        {
            context.Comments.Update(comment);
            context.SaveChanges();
        }
     public List<CommentModel> GetCommentsByStory(int StoryId)
    {

            List<CommentModel> comments = (from c in context.Comments
                                           where c.StoriesModelFormStoryID == StoryId
                                           select c).ToList();

         /*   var story = (from s in context.Story
                         where s.StoryID == StoryId
                         select s).FirstOrDefault();
            List<CommentModel> comments = new List<CommentModel>();
            foreach (CommentModel c in story.Comments)
            {
                comments.Add(c);
            }*/


             return comments;
            
    }
        public List<CommentModel> GetComments()
        {
            List<CommentModel> comments = (from c in context.Comments
                                          
                                           select c).ToList();

            return comments;
        }
        public CommentModel GetCommentById(int Id)
        {
            
            CommentModel comment = (from c in context.Comments
                                     where c.CommentId == Id
                                       select c).FirstOrDefault();

            return comment;
        }

       
    }
}
