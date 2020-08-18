using System;
using System.Collections.Generic;
using System.Text;
using Mini_CStructor.Database;

namespace Mini_CStructor.Repository
{
    class DatabaseAccessor
    {
        static DatabaseAccessor()
        {
            Instance = new minicstructorContext();
        }

        public static minicstructorContext Instance { get; private set; }
    }
}