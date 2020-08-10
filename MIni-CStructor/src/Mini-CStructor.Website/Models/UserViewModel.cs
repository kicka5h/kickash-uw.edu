using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mini_CStructor.Website.Models;

namespace Mini_CStructor.Website.Models
{
    public class UserViewModel
    {
        public UserModel User { get; set; }
        public ClassModel[] Classes { get; set; }
    }
}
