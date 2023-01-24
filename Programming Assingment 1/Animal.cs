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
        
        public Animal(string name, int age, string noise, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Noise = noise;
            this.Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public string GetNoise()
        {
            return Noise;
        }

        public abstract void printInfo();

        public abstract void makeNoise();

        public abstract void ageUp();
    }
}
