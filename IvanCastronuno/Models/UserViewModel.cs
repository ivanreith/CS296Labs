using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace IvanCastronuno.Models
{
    public class UserViewModel
    {
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
