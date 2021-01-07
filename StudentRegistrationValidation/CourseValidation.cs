using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationCodeFirstFromDB;

namespace StudentRegistrationValidation
{
    public static class CourseValidation
    {
        /// <summary>
        /// Checking if some of the info of the course is invalid
        /// </summary>
        /// <param name="course"> course to be validated</param>
        /// <returns></returns>
        public static bool InfoIsInvalid(this Course course)
        {
            // check if 0 or null or empty
            return (course.CourseNumber == 0 || course.CourseName == null ||
                course.CourseName.Trim().Length == 0);
        }



    }
}
