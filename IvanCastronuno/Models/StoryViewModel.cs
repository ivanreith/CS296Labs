using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IvanCastronuno.Models
{
    public class StoryViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Title between 1 and 50 chars")]
        public string StoryTitle { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "storyTopic between 1 and 25 chars")]
        public string StoryTopic { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "storyText between 1 and 250 chars")]
        public string StoryText { get; set; }

        // changfe due to identity  =>  stuff public string Name { get; set; }
        public string PosterName { get; set; }

        

      

    }
}
