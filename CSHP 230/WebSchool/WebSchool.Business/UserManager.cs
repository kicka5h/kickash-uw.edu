using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSchool.Repository;

namespace WebSchool.Business
{
    public interface IUserManager
    {
        UserModel LogIn(string email, string password);
        UserModel Register(string email, string password);
    }
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsAdmin { get; set; }
    }

    class UserManager : IUserManager
    {
        private readonly IUserRepository userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public UserModel LogIn(string email, string password)
        {
            var user = userRepository.Login(email, password);

            if (user == null)
            {
                return null;
            }

            return new UserModel { UserId = user.UserId, UserEmail = user.UserEmail };
        }

        public UserModel Register(string email, string password)
        {
            var user = userRepository.Register(email, password);

            if (user == null)
            {
                return null;
            }

            return new UserModel { UserId = user.UserId, UserEmail = user.UserEmail, UserPassword = user.UserPassword };
        }
    }
}
