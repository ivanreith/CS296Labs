using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace IvanCastronuno.Models
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage ="Enter Name!!")]
        [StringLength(255)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Enter Password!!")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password!!")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}
