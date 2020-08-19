using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_CStructor.WebSite.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsAdmin { get; set; }
    }
}