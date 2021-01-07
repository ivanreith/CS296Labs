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
        public string UserName { get; set; }
    }



}
