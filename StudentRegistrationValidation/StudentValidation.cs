using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationCodeFirstFromDB;

namespace StudentRegistrationValidation
{
    public static class StudentValidation
    {
        /// <summary>
        /// Method to validate student's information
        /// </summary>
        /// <param name="student"> student to be validated</param>
        /// <returns></returns>        
        public static bool InfoIsInvalid(this Student student)
        {
            // check if any nulls or empty!
            return (student.StudentFirstName == null || student.StudentFirstName.Trim().Length == 0 ||
                student.StudentLastName == null || student.StudentLastName.Trim().Length == 0);
        }
    }
}
