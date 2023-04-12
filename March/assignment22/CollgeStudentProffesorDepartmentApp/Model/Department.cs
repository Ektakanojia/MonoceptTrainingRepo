using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollgeStudentProffesorDepartmentApp.Model
{
    internal class Department
    {
        public string DepartmentName
        {
            get; set;
        }
        public string DepartmentCode
        {
            get; set;
        }

        public Department(string departmentName, string departmentCode)
        {
            DepartmentName= departmentName;
            DepartmentCode= departmentCode;
        }
    }
}
