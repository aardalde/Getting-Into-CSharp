// Aaron Alden
// Dr. Ericson
// CSCI 352
// January 16, 2023
// Animal.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assingment_1
{
    abstract class Animal
    {
        private string Name;
        private int Age;
        private string Noise;
        private double Weight;

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetNoise()
        {
            return Noise;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public abstract void printInfo();

        public abstract void makeNoise();

        public abstract void ageUp();
    }
}
