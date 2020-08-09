using System;
using System.Collections.Generic;

namespace Mini_CStructor.Database
{
    public partial class Class
    {
        public Class()
        {
            UserClass = new HashSet<UserClass>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public decimal ClassPrice { get; set; }

        public virtual ICollection<UserClass> UserClass { get; set; }
    }
}
