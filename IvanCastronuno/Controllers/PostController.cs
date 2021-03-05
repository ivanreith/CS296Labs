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
    public class PostController : ControllerBase
    {
        IStories Repo;
      
        public PostController(IStories r )
        {
           
            Repo = r;
          
        }


        [HttpGet]
        public IActionResult GetPost()
        {
            var posts = Repo.stories.ToList<StoriesModelForm>(); 
            if (posts.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(posts);
            }
           
        }
        [HttpGet("{id}")]
        public IActionResult GetPostById(int Id)
        {
            var post = Repo.GetStoryById(Id);
            if (post == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(post);
            }

        }

        [HttpPost]
        public IActionResult AddPost([FromBody] StoryViewModel storyVM)
        {
            if (storyVM != null)
            {
                var story = new StoriesModelForm
                {
                    StoryTitle = storyVM.StoryTitle,
                    StoryTopic = storyVM.StoryTopic,
                    StoryText = storyVM.StoryText,
                    Poster = new AppUser { UserName = storyVM.PosterName },
                    StoryTime = DateTime.Now
                };
            
            Repo.AddStory(story);
            return Ok(story);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public IActionResult EditPost ([FromBody] StoryViewModel storyVM,int Id)
        {
            var post = Repo.GetStoryById(Id);

            if (storyVM == null || post == null)
            { 
                return BadRequest();
            }
            post.StoryTitle = storyVM.StoryTitle;
            post.StoryTopic = storyVM.StoryTopic;
            post.StoryText = storyVM.StoryText;
            post.StoryTime = DateTime.Now;

            Repo.UpdateStory(post);
            return Ok(post);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletePost (int Id)
        {
           var post = Repo.GetStoryById(Id);
            if (post == null)
            {
                return NotFound();

            }
            Repo.DeleteStory(post);


            return Ok(post);
        }



    }
}
