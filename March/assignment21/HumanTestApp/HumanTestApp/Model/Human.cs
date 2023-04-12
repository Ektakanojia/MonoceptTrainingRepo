using HumanTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClassLib.Model
{

    public class Human
    {
        private string _name;
        private int _age;
        private double _height;
        private double _weight;
       
        //added enum for gender
        private GenderOption _genderOption;

        public Human(string name, int age, double height, double weight, GenderOption genderOption)
        {
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
           
            _genderOption = genderOption;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
       
        public GenderOption GenderOption
        {
            get { return _genderOption; }
        }


        public void Workout()
        {
            
            _weight -= (_weight * 0.05f);
           
        }

        public void Eat()
        {
           
            _weight += (_weight * 0.1f);
            _height += (_height * 0.02f);
            
        }
        //function for calculating the BMI
        public double BodyMassIndex(double height, double weight)
        {
            double bmi;
            if (height <= 0 || weight <= 0)
            {
                throw new Exception("Please enter valid height and weight");
            }
            height = height * height;
            bmi = (weight / height);
            
            return bmi;

        }
    }
}
