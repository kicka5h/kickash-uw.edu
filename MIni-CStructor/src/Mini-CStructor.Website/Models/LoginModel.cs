using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mini_CStructor.Website.Models
{
    public class LoginModel
    {
        public int UserId { get; set; }

        [Required]
        [Display(Name = "User Email")]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "User Password")]
        public string UserPassword { get; set; }
    }
}
