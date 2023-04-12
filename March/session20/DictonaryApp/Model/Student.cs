using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryApp.Model
{
    internal class Student
    {
        private int _standard;
        public int Id { get; set; }
        public string Name { get; set; }

        public int Standard
        {
            get
            {

                return _standard;

            }
            set
            {
                if (value >= 0 && value <= 12)
                {
                _standard= value;
                }


            }
        }

        public override int GetHashCode()
        {
           return (this.Standard + this.Id).GetHashCode();
           
        }

        public override bool Equals(object? second)
        {
            /// return base.Equals(obj);
            Student secondStudent = (Student)second;
            return this.Id == secondStudent.Id;


        }
    }
}
