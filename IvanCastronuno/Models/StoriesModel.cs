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
        // [Required]
        //  [MaxLength(50, ErrorMessage ="Title between 1 and 50 chars")]
        public string StoryTitle { get; set; }
      //  [Required]
       // [MaxLength(25, ErrorMessage = "storyTopic between 1 and 25 chars")]
        public string StoryTopic { get; set; }
      //  [Required]
      //  [MaxLength(250, ErrorMessage = "storyText between 1 and 250 chars")]
        public string StoryText { get; set; }
        //  [Required]
        //  [MaxLength(250, ErrorMessage = "storyTeller between 1 and 250 chars")]
        public string UserId { get; set; }
        public User Poster { get; set; }       
         
        //public DateTime StoryDate { get; set; }

        public string Slug =>
         StoryTitle?.Replace(' ', '-').ToLower() + '-' + StoryTopic.ToString();

    }
    
}
