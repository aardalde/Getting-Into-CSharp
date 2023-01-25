/* 
 * Author: Aaron Alden
 * Date: January 24, 2023
 * File: Driver.cs
 * Description: This file presents the user with a menu-driven interface. They can select options such as adding a new animal, hearing the sound it makes, etc.
 * Programming Enviornment: Visual Studio 2019, Windows 11
 */

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
            string userChoice, subMenuChoice;
            int numberChoice;

            Console.WriteLine("Welcome!");
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
                    Console.WriteLine("Please enter the number of the option you would like to access: ");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("(1) Cat");
                    Console.WriteLine("(2) Cassowary");
                    Console.WriteLine("(3) Gorilla");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Enter your choice: ");
                    subMenuChoice = Console.ReadLine();
                    if (!Int32.TryParse(subMenuChoice, out numberChoice)) continue;

                    if (subMenuChoice == "1")
                    {
                        Console.WriteLine("Enter the name of the cat: ");
                        string animalName = Console.ReadLine();
                        Console.WriteLine("Enter the age of the cat: ");
                        int animalAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the noise of the cat: ");
                        string animalNoise = Console.ReadLine();
                        Console.WriteLine("Enter the weight of the cat: ");
                        double animalWeight = Convert.ToInt32(Console.ReadLine());
                        Cat cat = new Cat(animalName, animalAge, animalNoise, animalWeight);
                        animals.Add(cat);
                        Console.WriteLine("Here is your new entry for this Cat: ");
                        Console.WriteLine("=====================================");
                        cat.printInfo();
                        Console.WriteLine("=====================================");
                    }

                    if (subMenuChoice == "2")
                    {
                        Console.WriteLine("Enter the name of the cassowary: ");
                        string animalName = Console.ReadLine();
                        Console.WriteLine("Enter the age of the cassowary: ");
                        int animalAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the noise of the cassowary: ");
                        string animalNoise = Console.ReadLine();
                        Console.WriteLine("Enter the weight of the cassowary: ");
                        double animalWeight = Convert.ToInt32(Console.ReadLine());
                        Cassowary cassowary = new Cassowary(animalName, animalAge, animalNoise, animalWeight);
                        animals.Add(cassowary);
                        Console.WriteLine("Here is your new entry for this Cassowary: ");
                        Console.WriteLine("=====================================");
                        cassowary.printInfo();
                        Console.WriteLine("=====================================");
                    }

                    if (subMenuChoice == "3")
                    {
                        Console.WriteLine("Enter the name of the gorilla: ");
                        string animalName = Console.ReadLine();
                        Console.WriteLine("Enter the age of the gorilla: ");
                        int animalAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the noise of the gorilla: ");
                        string animalNoise = Console.ReadLine();
                        Console.WriteLine("Enter the weight of the gorilla: ");
                        double animalWeight = Convert.ToInt32(Console.ReadLine());
                        Gorilla gorilla = new Gorilla(animalName, animalAge, animalNoise, animalWeight);
                        animals.Add(gorilla);
                        Console.WriteLine("Here is your new entry for this Gorilla: ");
                        Console.WriteLine("=====================================");
                        gorilla.printInfo();
                        Console.WriteLine("=====================================");
                    }
                }
                if (userChoice == "2")
                {
                    Console.WriteLine("Please enter the name of the animal whose information you would like to access: ");
                    string animalName = Console.ReadLine();
                    for (int i = 0; i < animals.Count; i++)
                    {
                        if (animalName == animals[i].GetName())
                        {
                            Console.WriteLine("=====================================");
                            animals[i].printInfo();
                            Console.WriteLine("=====================================");
                        }
                    }
                }
                if (userChoice == "3")
                {
                    Console.WriteLine("Enter the name of the animal whose age you wish to increase: ");
                    string animalName = Console.ReadLine();
                    for (int i = 0; i < animals.Count; i++)
                    {
                        if (animalName == animals[i].GetName())
                        {
                            animals[i].ageUp();
                        }
                    }
                }
                if (userChoice == "4")
                {
                    Console.WriteLine("Enter the name of the animal whose call you wish to hear: ");
                    string animalName = Console.ReadLine();
                    for (int i = 0; i < animals.Count; i++)
                    {
                        if (animalName == animals[i].GetName())
                        {
                            Console.WriteLine("=====================================");
                            animals[i].makeNoise();
                            Console.WriteLine("=====================================");
                        }
                    }
                }
                if (userChoice == "5")
                {
                    Environment.Exit(0);
                }
            } while (true);
        }
    }
}