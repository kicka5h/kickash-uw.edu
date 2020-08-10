using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mini_CStructor.Website.Models;

namespace Mini_CStructor.Website.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsAdmin { get; set; }

        public UserModel (int userID, string userEmail, string userPassword, bool userIsAdmin)
        {
            UserId = userID;
            UserEmail = userEmail;
            UserPassword = userPassword;
            UserIsAdmin = userIsAdmin;
        }
    }
}
