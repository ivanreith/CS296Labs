using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IvanCastronuno.Models
{
    public class CommentViewModel
    {
        public int StoryID { get; set; }
       public string StoryTopic { get; set; }
        public string CommentText { get; set; }
       
    }
}
