/* 
 * Author: Aaron Alden
 * Date: January 24, 2023
 * File: Cat.cs
 * Description: This file implements the child class behaviors of the Cat animal. Like the other child classes, it inherits and implements the public methods from its parent class
 * Programming Enviornment: Visual Studio 2019, Windows 11
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assingment_1
{
    class Cat : Animal
    {
        /*
         * Description:
         *  A parameterized constructor that inherits the base class parameterized constructor to allow the use of the private member variables
         * 
         * Inputs:
         *  string name, int age, string noise, double weight
         * 
         * Returns:
         *  N/A
         */
        public Cat(string name, int age, string noise, double weight) : base(name, age, noise, weight)
        {
            name = GetName();
            age = GetAge();
            noise = GetNoise();
            weight = GetWeight();

        }

        /*
         * Description:
         *  A function that prints out to the user all the associated information about the cat
         * 
         * Inputs:
         *  N/A
         * 
         * Returns:
         *  N/A
         */
        public override void printInfo()
        {
            Console.WriteLine("This cat's name is: " + GetName());
            Console.WriteLine(GetName() + "'s age is " + GetAge() + " years");
            Console.WriteLine(GetName() + "'s weight is " + GetWeight() + " pounds");
            Console.WriteLine("Shhh. Listen... " + GetName() + "'s Calling out to us: " +
              GetNoise());
        }

        /*
         * Description:
         *  A function that writes to the console the current sound the cat makes
         * 
         * Inputs:
         *  N/A
         * 
         * Returns:
         *  N/A
         */
        public override void makeNoise()
        {
            Console.WriteLine(GetNoise());
        }

        /*
         * Description:
         *  A function that reads from the user the number of years they would like to increase the age of the cat by
         * 
         * Inputs:
         *  N/A
         * 
         * Returns:
         *  N/A
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