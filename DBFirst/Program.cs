using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = CourseLevel.Beginner;
        }
    }
}
