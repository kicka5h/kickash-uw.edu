using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_CStructor.Repository
{
    public interface IUserRepository
    {
        UserModel LogIn(string userEmail, string userPassword);
        UserModel Register(string userEmail, string userPassword);
    }

    public class UserModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsAdmin { get; set; }
    }

    public class UserRepository : IUserRepository
    {
        public UserModel LogIn(string userEmail, string userPassword)
        {
            var user = DatabaseAccessor.Instance.Users
                .FirstOrDefault(t => t.UserEmail.ToLower() == userEmail.ToLower()
                                      && t.UserPassword == userPassword);

            if (user == null)
            {
                return null;
            }

            return new UserModel { UserId = user.UserId, UserEmail = user.UserEmail };
        }

        public UserModel Register(string userEmail, string userPassword)
        {
            var user = DatabaseAccessor.Instance.Users
                    .Add(new Mini_CStructor.Database.User
                    {
                        UserEmail = userEmail,
                        UserPassword = userPassword
                    });

            DatabaseAccessor.Instance.SaveChanges();

            return new UserModel { UserId = user.UserId, UserEmail = user.UserEmail };
        }
    }
}
