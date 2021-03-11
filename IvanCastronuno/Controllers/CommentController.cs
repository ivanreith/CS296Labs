using IvanCastronuno.Models;
using IvanCastronuno.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IvanCastronuno.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        IStories Repo;

        public CommentController(IStories r)
        {

            Repo = r;

        }

        public IActionResult AddComment([FromBody] CommentViewModel commentVM)
        {
            // here we pass the data from the view into the new real model for the DB
            var comment = new CommentModel { CommentText = commentVM.CommentText };
            if (commentVM.StoryID > 1000 && commentVM.CommentText != null) // to check if it got to this point empty, ZAP testing
            {
                comment.Commenter = new AppUser { Name = commentVM.CommenterName };
                comment.CommentDate = DateTime.Now;
                // Now we start working on the DB:
                var story = Repo.GetStoryById(commentVM.StoryID);

               /* var story = (from s in Repo.stories
                             where s.StoryID == commentVM.StoryID
                             select s).FirstOrDefault<StoriesModelForm>();  */// after first supposed to go <StoriesModelForm> but visual says it can be omitted.
                                                                            //  now adding the comment to the story object variable that we've retrieved:        
                if (story != null)
                {
                    story.Comments.Add(comment);
                    Repo.UpdateStory(story);
                    return Ok(commentVM);
                }
            }
            else
            {

                return BadRequest(); ;
            }

           


            return NotFound();
        }
        /*
        [HttpGet("{id}")]
        public IActionResult GetCommentsFromPost(int Id)
        {
             
            List<CommentModel> comments = Repo.GetCommentsByStory(Id);
            if (comments.Count == 0)
            {
                return NotFound(Id);
            }

            return Ok(comments);
        } */ // removed due to duplicate methods with parameters int id
        [HttpGet]
        public IActionResult GetComments()
        {
            List<CommentModel> comments = Repo.GetComments().ToList();
            if (comments.Count > 0)
            {
                return Ok(comments);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GetCommentById(int Id)
        {
            CommentModel comment = Repo.GetCommentById(Id);
            if (comment != null)
            {
                return Ok(comment);
            }
            return NotFound(Id);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int Id)
        {
            CommentModel comment = Repo.GetCommentById(Id);
            if (comment != null)
            {
                Repo.DeleteComment(comment);
                return Ok(comment);
            }
            return NotFound(Id);
           
        }
        [HttpPut("{id}")]
        public IActionResult UpdateComment(int Id, CommentViewModel CommentVM)
        {
            if (CommentVM != null )
            {
                CommentModel comment = Repo.GetCommentById(Id);
                comment.CommentDate = DateTime.Now;                
                comment.CommentText = CommentVM.CommentText;
             
                Repo.UpdateComment(comment);

                return Ok(comment);
            }


            return NotFound();
        }

    }
}
