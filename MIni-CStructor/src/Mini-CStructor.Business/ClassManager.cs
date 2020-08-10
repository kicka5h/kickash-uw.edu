using Mini_CStructor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mini_CStructor.Business
{
    public interface IClassManager
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

        public ClassModel(int classId, string className, string classDescription, decimal classPrice)
        {
            ClassId = classId;
            ClassName = className;
            ClassDescription = classDescription;
            ClassPrice = classPrice;
        }
    }
    public class ClassManager : IClassManager
    {
        private readonly IClassRepository classRepository;

        public ClassManager(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        public ClassModel[] Classes
        {
            get
            {
                return classRepository.Classes
                                      .Select(t => new ClassModel(t.ClassId, t.ClassName, t.ClassDescription, t.ClassPrice))
                                      .ToArray();
            }
        }

        public ClassModel Class(int classId)
        {
            var classModel = classRepository.Class(classId);
            return new ClassModel(classModel.ClassId, classModel.ClassName, classModel.ClassDescription, classModel.ClassPrice);
        }
    }
}
