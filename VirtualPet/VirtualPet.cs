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
        private int hungerLevel;
        private int thirstLevel;
        private int wasteLevel;
        private int boredomLevel;
        private int sicknessLevel;

        //Properties
        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }

        public int ThirstLevel
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = value; }
        }

        public int WasteLevel
        {
            get { return this.wasteLevel; }
            set { this.wasteLevel = value; }
        }

        public int BoredomLevel
        {
            get { return this.boredomLevel; }
            set { this.boredomLevel = value; }
        }

        public int SicknessLevel
        {
            get { return this.sicknessLevel; }
            set { this.sicknessLevel = value; }
        }

        //Constructor

        public VirtualPet()
        {
            //default constructor
        }

        //Methods
        public void GetFood()
        {

        }

        public void GetWater()
        {

        }

        public void GoPotty()
        {

        }

        public void GoPlay()
        {

        }

        public void GetDoctor()
        {

        }

        public void Tick()
        {

        }
    }
}
