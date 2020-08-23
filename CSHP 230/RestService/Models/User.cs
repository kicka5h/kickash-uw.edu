using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
        public string Password { get; set; }
    }
}
