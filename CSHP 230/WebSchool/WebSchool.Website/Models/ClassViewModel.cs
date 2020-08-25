using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSchool.Website.Models
{
    public class ClassViewModel
    {
        public ClassModel[] Classes { get; set; }
        public ClassModel ForClass { get; set; }

        public class ClassRegisterModel
        {
            public int ClassId { get; set; }
            public string ClassName { get; set; }
            public string ClassDescription { get; set; }
            public decimal ClassPrice { get; set; }
        }
    }
}