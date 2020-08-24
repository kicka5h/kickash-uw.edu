﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSchool.ClassDatabase;

namespace WebSchool.Repository
{
    class DatabaseAccessor
    {
        private static readonly ClassDbEntities entities;

        static DatabaseAccessor()
        {
            entities = new ClassDbEntities();
            entities.Database.Connection.Open();
        }

        public static ClassDbEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
