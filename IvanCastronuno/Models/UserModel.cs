using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;


namespace IvanCastronuno.Models
{

    public class User
    {
        public string UserId { get; set; }
        [Required (ErrorMessage = "Name is required....")]
        [MaxLength(50, ErrorMessage = "Name between 1 and 50 chars")]
        public string UserName { get; set; }
    }



}
