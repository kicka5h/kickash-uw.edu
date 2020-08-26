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
    }

    public class UserClassModel
    {
        public int UserId { get; set; }
        public int ClassId { get; set; }
    }
    class UserClassManager : IUserClassManager
    {
        private readonly IUserClassRepository userClassRepository;

        public UserClassManager(IUserClassRepository userClassRepository)
        {
            this.userClassRepository = userClassRepository;
        }

        public UserClassModel AddClass(int userId, int classId)
        {
            var userClass = userClassRepository.AddClass(userId, classId);

            if (userClass == null)
            {
                return null;
            }

            return new UserClassModel { ClassId = userClass.ClassId, UserId = userClass.UserId };
        }
    }
}
