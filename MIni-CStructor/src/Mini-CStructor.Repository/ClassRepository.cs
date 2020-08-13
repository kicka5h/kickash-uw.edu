using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mini_CStructor.Repository
{
    public interface IClassRepository
    {
        ClassModel[] Classes { get; }
        ClassModel Class(int classId);
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
        public ClassModel[] Classes
        {
            get
            {
                return DatabaseAccessor.Instance.Class
                                                .Select(t => new ClassModel { ClassId = t.ClassId, ClassName = t.ClassName, ClassDescription = t.ClassDescription, ClassPrice = t.ClassPrice })
                                                .ToArray();

            }
        }

        public ClassModel Class(int classId)
        {
            var Class = DatabaseAccessor.Instance.Class
                                                 .Where(t => t.ClassId == classId)
                                                 .Select(t => new ClassModel { ClassId = t.ClassId, ClassName = t.ClassName, ClassDescription = t.ClassDescription, ClassPrice = t.ClassPrice })
                                                 .First();
            return Class;
        }
    }
}
