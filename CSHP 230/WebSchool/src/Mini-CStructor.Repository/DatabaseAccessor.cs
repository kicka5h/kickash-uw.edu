using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_CStructor.Database;

namespace Mini_CStructor.Repository
{
    public class DatabaseAccessor
    {
        private static readonly DbEntities entities;

        static DatabaseAccessor()
        {
            entities = new DbEntities();
            entities.Database.Connection.Open();
        }

        public static DbEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
