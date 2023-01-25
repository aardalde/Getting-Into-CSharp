/* 
 * Author: Aaron Alden
 * Date: January 24, 2023
 * File: Cassowary.cs
 * Description: This file implements the child class behaviors of the Cassowary animal. Like the other child classes, it inherits and implements the public methods from its parent class
 * Programming Enviornment: Visual Studio 2019, Windows 11
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assingment_1
{
    class Cassowary : Animal
    {
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
        public Cassowary(string name, int age, string noise, double weight) : base(name, age, noise, weight)
        {

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
        public override void printInfo()
        {
            Console.WriteLine("This Cassowary's name is: " + GetName());
            Console.WriteLine(GetName() + "'s age is " + GetAge() + " years");
            Console.WriteLine(GetName() + "'s weight is " + GetWeight() + " pounds");
            Console.WriteLine("Shhh. Listen... " + GetName() + "'s Calling out to us: " +
              GetNoise());
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
        public override void makeNoise()
        {
            Console.WriteLine(GetNoise());
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
        public override void ageUp()
        {
            Console.WriteLine("Enter the number of years you would like to add on: ");
            int ageIncrease = int.Parse(Console.ReadLine());
            int newAge = ageIncrease + GetAge();
            Console.WriteLine("=====================================");
            Console.WriteLine("New age: " + newAge);
            Console.WriteLine("=====================================");
        }
    }
}