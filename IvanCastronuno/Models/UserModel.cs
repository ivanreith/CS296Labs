using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using Microsoft.AspNetCore.Identity;

namespace IvanCastronuno.Models
{

    public class AppUser : IdentityUser
    {
        
        [Required (ErrorMessage = "Name is required....")]
        [MaxLength(50, ErrorMessage = "Name between 1 and 50 chars")]
        public string Name { get; set; }
    }



}
