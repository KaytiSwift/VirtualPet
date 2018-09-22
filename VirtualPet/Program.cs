using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiates an instance of the VirtualPet class
            VirtualPet pet = new VirtualPet();
            bool restart = true;
            do //runs entire program once, prompts to play again or quit
            {                
                bool exit = false; 

                //Prompts the user to name the Elephant and saves input to Name
                Console.WriteLine("Please enter a name for your elephant.");
                string name = Console.ReadLine();
                pet.Name = name;

                do //loops the user interface
                {
                    //User Interface - displays pets current status, asks for an action, and gives list of choices  
                    Console.WriteLine();
                    Console.WriteLine("{0} the Elephant", pet.Name);
                    Console.WriteLine();
                    Console.WriteLine("Hunger level is at {0}", pet.Hunger);
                    Console.WriteLine("Thirst level is at {0}", pet.Thirst);
                    Console.WriteLine("Potty level is at {0}", pet.Potty);
                    Console.WriteLine("Boredom level is at {0}", pet.Boredom);
                    Console.WriteLine("Sadness level {0}", pet.Sadness);
                    Console.WriteLine();
                    pet.UrgentNeeds();
                    Console.WriteLine("{0} is ready! What do you want to do?", pet.Name);
                    Console.WriteLine();
                    Console.WriteLine("Type \"feed\" to feed {0}.", pet.Name);
                    Console.WriteLine("Type \"water\" to give {0} something to drink.", pet.Name);
                    Console.WriteLine("Type \"potty\" to give {0} a potty break.", pet.Name);
                    Console.WriteLine("Type \"play\" to play with {0}.", pet.Name);
                    Console.WriteLine("Type \"nothing\" to do nothing.\n", pet.Name);

                    //takes user input and decides action, calling methods
                    string input = Console.ReadLine().ToLower();

                    switch (input)
                    {
                        case "feed":
                            pet.GetFood(); 
                            break;

                        case "water":
                            pet.GetWater();
                            break;

                        case "potty":
                            pet.GoPotty();
                            break;

                        case "play":
                            pet.GoPlay();
                            break;

                        case "nothing":
                            pet.IncreaseSadness();
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("I did not understand you!");
                            Console.WriteLine();
                            break;
                    }

                    pet.Tick(); // calls Tick method

                    Console.WriteLine("It's been an hour. Press enter to interact with {0} some more or type \"exit\" to quit", pet.Name);
                    string reply = Console.ReadLine().ToLower();
                    if (reply == "exit")
                    {
                        exit = true;
                    }

                } while (exit == false);

                //Thanks the user for playing and asks if they want to play again. Restarts the loop if they type yes 
                Console.WriteLine("Good job! {0} appreciates you!", pet.Name);
                Console.WriteLine("Do you want to play with another pet? Type \"yes\" to play again.");
                string response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    pet.Hunger = 0;
                    pet.Thirst = 0;
                    pet.Potty = 0;
                    pet.Boredom = 1;
                    pet.Sadness = 0;
                }
                else
                {
                    restart = false;
                }
            } while (restart == true);

            Console.WriteLine("Thank you for playing!");
                        
        }
    }
}
