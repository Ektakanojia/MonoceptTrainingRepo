using System;
namespace StudentApp.Model
{
    internal class Student
    {
        private string _name;
        private int _rollno;
        private  float _cgpa;

        public Student(string name, int rollno, float cgpa)
        {
            _name = CheckName(name);
            _rollno = ValidateRollno( rollno);
            _cgpa = CalculatePercentage(cgpa);
        }
        public int ValidateRollno(int rollno)
        {
            if (rollno > 0)
            {
               
                return _rollno; 
            }
            else
            {
                return 0;
                
            }
        }
        public string CheckName(string name)
        {
            if (name.Length>= 5)
            {
                return name;
                
            }
            else
            {
                return " ";
            }
        }
        public float CalculatePercentage(float cgpa)
        {
            //float percentage = 0;
            if (cgpa >= 1 && cgpa <= 10)
            {
                return (cgpa * 9.5f);
            }
            else
            {
                return 0;
            }
            
        }
       
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = CheckName(value);
            }
           
        }
        public int Rollno
        {
            get
            {
                return _rollno;
            }
            set
            {
                _rollno = ValidateRollno(value);
            }
        }
        public float Percentage
        {
            get
            {
                return _cgpa;
            }
            set
            {
                _cgpa = CalculatePercentage(value);
            }
        }

    }
}
