// Aaron Alden
// Dr. Ericson
// CSCI 352
// January 16, 2023
// Cassowary.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assingment_1
{
    class Cassowary : Animal(name, age, noise, weight)
    {
        public override void printInfo()
        {
            Console.WriteLine("This Cassowary's name is: " + GetName());
            Console.WriteLine(GetName() + "'s age is " + GetAge() + " years");
            Console.WriteLine(GetName() + "'s weight is " + GetWeight() + " pounds");
            Console.WriteLine("Shhh. Listen... " + GetName() + "'s Calling out to us: " +
                GetNoise());
        }
        public override void makeNoise()
        {
            Console.WriteLine(GetNoise());
        }

        public override void ageUp()
        {
            Console.WriteLine("Enter the number of years you would like to add on: ");
            int ageIncrease = int.Parse(Console.ReadLine());
            int newAge = ageIncrease + GetAge();
            Console.WriteLine("New age " + newAge);
        }
    }
}

