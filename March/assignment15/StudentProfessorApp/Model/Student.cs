using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorApp.Model
{
    internal class Student:Person
    {
       // private string _branch;
        private Branch _branch;
        
        public Student(int id, string address, string dob,Branch branch) : base(id, address, dob)
        {
          _branch= branch;
        }

       

        public override string Profession
        {
            get { return "student"; }
        }
        public Branch Branch
        {

            get
            {
                return _branch;
            }
        }
    }
}
