using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSchool.Repository
{
    public interface IClassRepository
    {
        ClassModel[] ForClass(int classId);
        IEnumerable<ClassModel> Classes();
    }

    public class ClassModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public decimal ClassPrice { get; set; }
    }
    public class ClassRepository : IClassRepository
    {
        IEnumerable<ClassModel> IClassRepository.Classes()
        {
            return DatabaseAccessor.Instance.Classes.Select(t => new ClassModel
            {
                ClassId = t.ClassId,
                ClassName = t.ClassName,
                ClassDescription = t.ClassDescription,
                ClassPrice = t.ClassPrice
            }).ToArray();
        }

        ClassModel[] IClassRepository.ForClass(int classId)
        {
            return DatabaseAccessor.Instance.Classes.Select(t => new ClassModel
            {
                ClassId = t.ClassId,
                ClassName = t.ClassName,
                ClassDescription = t.ClassDescription,
                ClassPrice = t.ClassPrice
            }).ToArray();
        }
    }
}
