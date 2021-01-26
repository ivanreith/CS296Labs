using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace IvanCastronuno.Models
{
  

    public class StoriesModelForm
    {

        // EF Core will configure the database to generate this value
        [Key]
        public int StoryID { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Title between 1 and 50 chars")]
        public string StoryTitle { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "storyTopic between 1 and 25 chars")]
        public string StoryTopic { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "storyText between 1 and 250 chars")]
        public string StoryText { get; set; }

       public string Name { get; set; }   // changfe due to identity stuff 
        public AppUser Poster { get; set; }       
        
        public DateTime StoryTime { get; set; }

        public string Slug =>
         StoryTitle?.Replace(' ', '-').ToLower() + '-' + StoryTopic?.ToString();

    }
    
}
  