using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HumanLib.Models
{
    public class Human
    {
        private string _name;
        private string _gender;
        private int _age;
        private double _height;
        private double _weight;

        public Human(string Name, string Gender, int Age, double Height, double Weight)
        {
            _name = Name;
            _gender = Gender;
            _age = Age;
            _height = Height;
            _weight = Weight;

        }

        public string Name { get { return _name; } }
        public string Gender { get { return _gender; } }
        public int Age { get { return _age; } }
        public double Height { get { return _height; } }
        public double Weight { get { return _weight; } }

        public void Eat()
        {
            _weight += Weight * 0.10;
        }

        public void Workout()
        {
            _weight -= Weight * 0.05;
            _height += Height * 0.02;
        }
        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }
    }
}
