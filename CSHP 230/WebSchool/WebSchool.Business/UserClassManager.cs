using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSchool.Repository;

namespace WebSchool.Business
{
    public interface IUserClassManager
    {
        UserClassModel AddClass(int UserId, int ClassId);
        /*
        List<UserClassModel> GetUserClasses(int userId);
        */
    }

    public class UserClassModel
    {
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public ClassModel Class { get; set; }
        public UserModel User { get; set; }
    }
    class UserClassManager : IUserClassManager
    {
        private readonly IUserClassRepository userClassRepository;
        private readonly IUserRepository userRepository;
        private readonly IClassRepository classRepository;

        public UserClassManager(IUserClassRepository userClassRepository, IUserRepository userRepository, IClassRepository classRepository)
        {
            this.userClassRepository = userClassRepository;
            this.userRepository = userRepository;
            this.classRepository = classRepository;
        }

        public UserClassModel AddClass(int userId, int classId)
        {
            UserClassModel newUserClass = new UserClassModel();

            var addedClass = userClassRepository.AddClass(userId, classId);

            if (addedClass == null)
            {
                return null;
            }

            var newClass = new UserClassModel { ClassId = addedClass.ClassId, UserId = addedClass.UserId };

            return newClass;
        }

        /*
        public List<UserClassModel> GetUserClasses(int userId)
        {

            var userClasses = userClassRepository.GetUserClasses(userId)
                .Select(t =>
                {
                    var targetUser = n
                    var targetClass = classRepository.Class(t.ClassId).ToBusinessModel();

                    return new UserClassModel()
                    {
                        ClassId = t.ClassId,
                        UserId = t.UserId,
                        Class = targetClass,
                        User = targetUser
                    };
                })
                .ToList();

            return userClasses;
        }
        */
    }
}

