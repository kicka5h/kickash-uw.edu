using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Rest.Service.Models;

namespace Rest.Service
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }

        User Get(int id);
        int Delete(int id);
        void Update(int id, User value);
        void Save(User value);
    }

    public class UsersRepository : IUserRepository
    {
        public static List<User> users = new List<User>
        {
            new User {Id = 101, Email = "reseek@jaxphotography.net", Password = "mx=p>J8,"},
            new User {Id = 102, Email = "orogeny@groovetrove.org", Password = "3E-/Sw>`"},
            new User {Id = 103, Email = "rcricked@gekkogames.org", Password = "pR~8aZ'-"}
        };

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
        
        public void Update(int id, User value)
        {
            var matchId = users.FirstOrDefault(t => t.Id == id);

            if (matchId != null)
            {
                //update the user email
                var matchEmail = Regex.Match(value.Email, matchId.Email);
                string resultEmail = "";

                if (matchEmail.Success)
                    resultEmail = matchEmail.Value;
                else { matchId.Email = value.Email; }

                //update the user password
                var matchPassword = Regex.Match(value.Password, matchId.Password);
                var resultPassword = "";

                if (matchPassword.Success)
                    resultPassword = matchPassword.Value;
                else { matchId.Password = value.Password; }
            }
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
