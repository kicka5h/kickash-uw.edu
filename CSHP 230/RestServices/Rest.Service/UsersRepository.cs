using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rest.Service.Models;

namespace Rest.Service
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }

        User Get(int id);
        int Delete(int id);
        void Save(User value);
    }

    public class UsersRepository : IUserRepository
    {
        public static List<User> users = new List<User>();

        public IEnumerable<User> Users
        {
            get
            {
                return users;
            }
        }

        public int Delete(int id)
        {
            int elements = users.RemoveAll(t => t.Id == id);
            return elements;
        }

        public User Get(int id)
        {
            return users.FirstOrDefault(t => t.Id == id);
        }

        public void Save(User value)
        {
            value.Id = users.Count + 1;
            users.Add(value);
        }
    }
}
