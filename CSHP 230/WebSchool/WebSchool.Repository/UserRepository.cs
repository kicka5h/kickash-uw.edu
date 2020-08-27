﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSchool.ClassDatabase;

namespace WebSchool.Repository
{
    public interface IUserRepository
    {
        UserModel Login(string email, string password);
        UserModel Register(string email, string password);
        UserModel AddClass(int userId, int classId);
    }

    public class UserModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsAdmin { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }

    public class UserRepository : IUserRepository
    {
        public UserModel Login(string email, string password)
        {
            var user = DatabaseAccessor.Instance.Users
                .FirstOrDefault(t => t.UserEmail.ToLower() == email.ToLower()
                                      && t.UserPassword == password);

            if (user == null)
            {
                return null;
            }

            return new UserModel { UserId = user.UserId, UserEmail = user.UserEmail, UserPassword = user.UserPassword };
        }

        public UserModel Register(string email, string password)
        {
            var user = DatabaseAccessor.Instance.Users
                    .Add(new WebSchool.ClassDatabase.User
                    {
                        UserEmail = email,
                        UserPassword = password
                    });

            DatabaseAccessor.Instance.SaveChanges();

            return new UserModel { UserId = user.UserId, UserEmail = user.UserEmail, UserPassword = user.UserPassword };
        }

        public UserModel AddClass(int userId, int classId)
        {
            var classes = DatabaseAccessor.Instance.Classes.Where(t => t.ClassId == classId).ToList();

            return new UserModel { Classes = classes };
        }
    }
}
