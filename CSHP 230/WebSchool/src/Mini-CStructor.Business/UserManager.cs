using Mini_CStructor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_CStructor.Business
{
    public interface IUserManager
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

    public class UserManager : IUserManager
    {
        private readonly IUserRepository userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public UserModel LogIn(string userEmail, string userPassword)
        {
            var user = userRepository.LogIn(userEmail, userPassword);

            if (user == null)
            {
                return null;
            }

            return new UserModel { UserId = user.UserId, UserEmail = user.UserEmail, UserIsAdmin = user.UserIsAdmin, UserPassword = user.UserPassword };
        }

        public UserModel Register(string userEmail, string userPassword)
        {
            var user = userRepository.Register(userEmail, userPassword);

            if (user == null)
            {
                return null;
            }

            return new UserModel { UserId = user.UserId, UserEmail = user.UserEmail, UserIsAdmin = user.UserIsAdmin, UserPassword = user.UserPassword };
        }
    }
}
