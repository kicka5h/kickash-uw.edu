using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSchool.Repository;

namespace WebSchool.Business
{
    public interface IClassManager
    {
        ClassModel[] Classes();
    }

    public class ClassModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public decimal ClassPrice { get; set; }
    }

    class ClassManager : IClassManager
    {
        private readonly IClassRepository classRepository;

        public ClassManager(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        public ClassModel[] Classes()
        {
            return classRepository.Classes().Select(t => new ClassModel
            {
                ClassId = t.ClassId,
                ClassName = t.ClassName,
                ClassDescription = t.ClassDescription,
                ClassPrice = t.ClassPrice
            }).ToArray();
        }
    }
}
