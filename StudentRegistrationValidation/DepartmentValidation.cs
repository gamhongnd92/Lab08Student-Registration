using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationCodeFirstFromDB;

namespace StudentRegistrationValidation
{
    public static class DepartmentValidation
    {


        /// <summary>
        ///  Make sure all department info exists and is not blank
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public static bool InfoIsInvalid(this Department department)
        {
            return (department.DepartmentCode == null || department.DepartmentCode.Trim().Length == 0 ||
                    department.DepartmentName == null || department.DepartmentName.Trim().Length == 0);
        }
    }
}
