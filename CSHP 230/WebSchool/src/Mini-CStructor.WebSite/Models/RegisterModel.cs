using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_CStructor.WebSite.Models
{
    public class RegisterModel
    {
        [Required]
        [Display(Name = "User Email")]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "User Password")]
        public string UserPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("User Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}