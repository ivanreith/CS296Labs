using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IvanCastronuno.Models
{
    public class CommentModel
    {
        [Key]
        public int CommentId { get; set; }
        public int StoriesModelFormStoryID { get; set; }
        [Required]
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        [Required]
        public AppUser Commenter { get; set; }
    }
}
