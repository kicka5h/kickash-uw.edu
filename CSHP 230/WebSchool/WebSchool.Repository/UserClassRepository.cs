using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WebSchool.Repository
{
    public interface IUserClassRepository
    {
        UserClassModel AddClass(int UserId, int ClassId);
    }

    public class UserClassModel
    {
        public int UserId { get; set; }
        public int ClassId { get; set; }
    }

    public class UserClassRepository : IUserClassRepository
    {
        public UserClassModel AddClass(int userId, int classId)
        {
            var user = DatabaseAccessor.Instance.Users.FirstOrDefault(t => t.UserId == userId);
            var classes = DatabaseAccessor.Instance.Classes.FirstOrDefault(t => t.ClassId == classId);

            return new UserClassModel { ClassId = classes.ClassId, UserId = user.UserId };
        }
    }
}
