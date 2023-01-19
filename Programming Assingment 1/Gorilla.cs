// Aaron Alden
// Dr. Ericson
// CSCI 352
// January 16, 2023
// Gorilla.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assingment_1
{
    class Gorilla : Animal
    {
        public override void printInfo()
        {
            Console.WriteLine("This cat's name is: " + GetName());
            Console.WriteLine(GetName() + "'s age is " + GetAge() + " years");
            Console.WriteLine(GetName() + "'s weight is " + GetWeight() + " pounds");
            Console.WriteLine("Shhh. Listen... " + GetName() + "'s Calling out to us: " +
                GetNoise());
        }
        }
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
