// Aaron Alden
// Dr. Ericson
// CSCI 352
// January 16, 2023
// Cat.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assingment_1
{
    class Cat : Animal
    {
        public override void printInfo()
        {
            Console.WriteLine("This cat's name is: " + GetName());
            Console.WriteLine("This cat's name is: ");
            Console.WriteLine("This cat's name is: ");
            Console.WriteLine("This cat's name is: ");
        }

        public override void makeNoise()
        {
            // Need to implement
        }

        public override void ageUp()
        {
            // Need to implement
        }
    }
}
