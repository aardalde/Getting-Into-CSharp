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
         *  The base class paramerterized constructor
         * 
         * Inputs:
         *  The...
         * 
         * Returns:
         *  The...
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
         *  The...
         * 
         * Inputs:
         *  The...
         * 
         * Returns:
         *  The...
         */
        public string GetName()
        {
            return Name;
        }

        /*
         * Description:
         *  The...
         * 
         * Inputs:
         *  The...
         * 
         * Returns:
         *  The...
         */
        public int GetAge()
        {
            return Age;
        }

        /*
         * Description:
         *  The...
         * 
         * Inputs:
         *  The...
         * 
         * Returns:
         *  The...
         */
        public double GetWeight()
        {
            return Weight;
        }

        /*
         * Description:
         *  The...
         * 
         * Inputs:
         *  The...
         * 
         * Returns:
         *  The...
         */
        public string GetNoise()
        {
            return Noise;
        }

        /*
         * Description:
         *  The...
         * 
         * Inputs:
         *  The...
         * 
         * Returns:
         *  The...
         */
        public abstract void printInfo();

        /*
         * Description:
         *  The...
         * 
         * Inputs:
         *  The...
         * 
         * Returns:
         *  The...
         */
        public abstract void makeNoise();

        /*
         * Description:
         *  The...
         * 
         * Inputs:
         *  The...
         * 
         * Returns:
         *  The...
         */
        public abstract void ageUp();
    }
}