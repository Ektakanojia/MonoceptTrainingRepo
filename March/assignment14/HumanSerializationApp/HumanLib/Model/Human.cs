using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLib.Model
{
    public class Human
    {
        private  string _name;
        private int _age;
        private double _weight;
        private double _height;

        public Human(string name ,int age, double weigth,double height)
        {
            _name = name;
            _age = age;
            _weight = weigth;
            _height = height;

        }

        public static void Workout(double weight)
        {
            weight = weight - .50; 
        }

        public static void Eat(double weight ,double height)
        {
            weight = weight + .10;
            height = height + .20;
        }
        public string Name
        {
            get { return _name; }
        }
        public int Age
        {
            get { return _age; }
        }
        public double Weigth
        {
            get { return _weight; }
        }
        public double Height
        {
            get { return _height; }
        }
    }
}
