using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //Fields
        private string name;
        private int hunger = 0;    
        private int potty = 0;
        private int boredom = 1;
        private int sadness = 0;
        private int thirst = 0;
        

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Potty
        {
            get { return this.potty; }
            set { this.potty = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int Sadness
        {
            get { return this.sadness; }
            set { this.sadness = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        //Constructor
        public VirtualPet()
        {
            //default constructor
        }

        //Methods
        public void GetFood() //affects hunger, potty and sadness(if applicable)
        {
            if (Hunger <= 0) 
            {
                Console.WriteLine();
                Console.WriteLine("{0} is not hungry right now.", Name);
            }
            else 
            {
                Hunger = 0;
                Potty = Potty + 1;
                Console.WriteLine();
                Console.WriteLine("{0} is no longer hungry! But it increased her need to go potty.", Name);
            }
            if (Sadness > 0) 
            {
                Sadness = Sadness - 1;
            }
        }

        public void GoPotty() //affects potty and sadness(if applicable)
        {
            if (Potty <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("{0} does not need to go potty right now.", Name);
            }
            else
            {
                Potty = 0;
                Console.WriteLine();
                Console.WriteLine("{0} went potty!", Name);
            }
            if (Sadness > 0)
            {
                Sadness = Sadness - 1;
            }
        }

        public void GoPlay() //affects boredom, thirst and sadness(if applicable)
        {
            if (Boredom <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("{0} does not want to play right now.", Name);
            }
            else
            {
                Boredom = 0;
                Thirst = Thirst + 1;
                Console.WriteLine();
                Console.WriteLine("{0} is happy you played with her! But it made her more thirsty.", Name);
            }
            if (Sadness > 0)
            {
                Sadness = Sadness - 1;
            }
        }

        public void GetWater() //affects thirst and sadness(if applicable)
        {
            if (Boredom <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("{0} is not thirsty right now.", Name);
            }
            else
            {
                Thirst = 0;
                Potty = Potty + 1;
                Console.WriteLine();
                Console.WriteLine("{0}'s thirst is quenched! But it increased her need to go potty.", Name);
            }
            if (Sadness > 0)
            {
                Sadness = Sadness - 1;
            }
        }

        public void IncreaseSadness() //increases sadness
        {
            Sadness = Sadness + 1;
            Console.WriteLine();
            Console.WriteLine("{0} needs you! You made {0} sad. You should interact with her next time to decrease her sadness.", Name);
            Console.WriteLine();
        }

        public void Tick() //displays current levels and increases hunger, thirst, potty, and boredom
        {
            Console.WriteLine();
            Console.WriteLine("Hunger level is at {0}", Hunger);
            Console.WriteLine("Thirst level is at {0}", Thirst);
            Console.WriteLine("Potty level is at {0}", Potty);
            Console.WriteLine("Boredom level is at {0}", Boredom);
            Console.WriteLine("Sadness level is at {0}", Sadness);            
            Console.WriteLine();
            Hunger = Hunger + 1;
            Thirst = Thirst + 1;
            Potty = Potty + 1;
            Boredom = Boredom + 1;
            
        }

        public void UrgentNeeds() //displays notifications to the user when certain levels are too high
        {
            if (Hunger > 4)
            {
                Console.WriteLine("{0} is very hungry! You should feed her!", Name);
                Console.WriteLine();
            }
            if (Potty > 4)
            {
                Console.WriteLine("{0} really needs to go potty! You should take her out!", Name);
                Console.WriteLine();
            }
            if (Boredom > 4)
            {
                Console.WriteLine("{0} is very bored! You should play with her!", Name);
                Console.WriteLine();
            }
            if (Thirst > 4)
            {
                Console.WriteLine("{0} is very thirsty! You should give her some water!", Name);
                Console.WriteLine();
            }
        }
    }
}
