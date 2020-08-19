﻿using System;
using System.Collections.Generic;

namespace Mini_CStructor.Website
{
    public partial class UserClass
    {
        public int ClassId { get; set; }
        public int UserId { get; set; }

        public virtual Class Class { get; set; }
        public virtual User User { get; set; }
    }
}
