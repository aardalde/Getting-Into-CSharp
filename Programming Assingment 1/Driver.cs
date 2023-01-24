// Aaron Alden
// Dr. Ericson
// CSCI 352
// January 16, 2023
// Driver.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assingment_1
{
    class World
    {
        static void Main(string[] args)
        {
            string userChoice;
            int numberChoice;

            Console.WriteLine("Welcome to Aaron's strange menagerie!");
            Console.WriteLine("=====================================");
            List<Animal> animals = new List<Animal>();

            do
            {
                Console.WriteLine("Please enter the number of the option you would like to access: ");
                Console.WriteLine("(1) Add an animal and its associated information");
                Console.WriteLine("(2) Print the info of a requested animal");
                Console.WriteLine("(3) Increase the age of a requested animal");
                Console.WriteLine("(4) Listen to the call of a requested animal");
                Console.WriteLine("(5) Exit the program");
                Console.WriteLine("=====================================");
                Console.WriteLine("Enter your choice: ");
                
                userChoice = Console.ReadLine();

                if (!Int32.TryParse(userChoice, out numberChoice)) continue; //This checks to make sure that the user input is a number
                if (userChoice == "1")
                {
                    Animal Cat = new Cat();
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter the name of the cat: ");
                    string catName = Console.ReadLine(Cat.GetName());
                    
                    Console.WriteLine(Cat.GetName());
                    animals.Add(Cat); 
                }
                if (userChoice == "2")
                {
                    Console.WriteLine("===================345=============");
                }
                if (userChoice == "3")
                {
                    Console.WriteLine("===========4=========================");
                }
                if (userChoice == "3")
                {
                    Console.WriteLine("===========4=========================");
                }
                if (userChoice == "5")
                {
                    Environment.Exit(0);
                }
            } while (true);
        }
    }
}
