using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles._5_Depedency_Inversion_Principle
{
    public class dependencyInversionPrinciple
    {
        public static void Start()
        {
            //use main logic here
        }
    }

    public interface ICourse
    {
        void AddCourse();
    }

    public class Course : ICourse
    {
        public Course() { }

        public void AddCourse()
        {
            //Add course logic
        }
    }

    public class InstanceFactory : IFactory
    {
        private ICourse course;

        public ICourse GetCourseInstance
        {
            get
            {
                if (course is null)
                {
                    course = new Course();
                }

                return course;
            }
        }
    }

    public interface IFactory
    {
        public ICourse GetCourseInstance { get; }
    }



    public class CourseService
    {
        IFactory _factory;

        public CourseService()
        {
        }

        public bool AddCourse()
        {
            try
            {
                _factory.GetCourseInstance.AddCourse();

                return false;
            }
            catch
            {
                return false;
            }

        }
    }
}
