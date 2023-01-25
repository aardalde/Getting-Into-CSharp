/* 
 * Author: Aaron Alden
 * Date: January 24, 2023
 * File: Animal.cs
 * Description: This file is the abstract parent class that the 3 children inherit from. It declares private member variables and public methods needed for the child classes
 * Programming Enviornment: Visual Studio 2019, Windows 11
 */

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

        /*
         * Description:
         *  The base class paramerterized constructor initializes private member variables to be used by the child classes 
         * 
         * Inputs:
         *  string name, int age, string noise, double weight
         * 
         * Returns:
         *  N/A
         */
        public Animal(string name, int age, string noise, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Noise = noise;
            this.Weight = weight;
        }

        /*
         * Description:
         *  A function that allows the child classes to call and retrieve the current name
         * 
         * Inputs:
         *  N/A
         * 
         * Returns:
         *  string Name
         */
        public string GetName()
        {
            return Name;
        }

        /*
         * Description:
         *  A function that allows the child classes to call and retrieve the current age
         * 
         * Inputs:
         *  N/A
         * 
         * Returns:
         *  int Age
         */
        public int GetAge()
        {
            return Age;
        }

        /*
         * Description:
         *  A function that allows the child classes to call and retrieve the current weight
         * 
         * Inputs:
         *  N/A
         * 
         * Returns:
         *  double Weight
         */
        public double GetWeight()
        {
            return Weight;
        }

        /*
         * Description:
         *  A function that allows the child classes to call and retrieve the current noise
         * 
         * Inputs:
         *  N/A
         * 
         * Returns:
         *  string Noise
         */
        public string GetNoise()
        {
            return Noise;
        }

        // Description for implemented abstract functions found in the child classes
        public abstract void printInfo(); 

        public abstract void makeNoise();

        public abstract void ageUp();
    }
}