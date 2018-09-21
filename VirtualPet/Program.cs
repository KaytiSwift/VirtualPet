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

            //User Interface
            Console.WriteLine("Ellen the Elephant");
            Console.WriteLine("Hunger: {0}", pet.HungerLevel);
            Console.WriteLine("Thirst: {0}", pet.ThirstLevel);
            Console.WriteLine("Waste: {0}", pet.WasteLevel);
            Console.WriteLine("Boredom: {0}", pet.BoredomLevel);
            Console.WriteLine("Sickness: {0}", pet.SicknessLevel);
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Feed Ellen");
            Console.WriteLine("2. Give Ellen a drink");
            Console.WriteLine("3. Give Ellen a potty break");
            Console.WriteLine("4. Play with Ellen");
            Console.WriteLine("5. Take Ellen to the doctors.");
            Console.WriteLine("6. Do nothing");




        }
    }
}
