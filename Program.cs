using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU3_ship
{

    public class Ship
    {
        public string name;
        private string year;

        public Ship()
        {

        }

        public Ship(string name, string year)
        {
            this.name = name;
            this.year = year;
        }

        public Ship(string name)
        {
            this.name = name;
        }




        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getYear()
        {
            return year;
        }

        public void setYear(string year)
        {
            this.year = year;
        }

        public override string ToString()
        {
            return $"The name of the ship is: {name} and the year it was built is: {year}";
        }
    }
        class CruiseShip:Ship
        {
            private int maxPassengers;

            public CruiseShip()
            {

            }

            public CruiseShip(int maxPassengers)
            {
                this.maxPassengers = maxPassengers;
            }

            public CruiseShip(string name, int maxPassengers) : base(name)
            {
               
                //this.name = name;
                this.maxPassengers = maxPassengers;
            }

            public int getMaxPassengers() {
                return maxPassengers;
            }
            public void setMaxPassengers(int maxPassengers) {
                this.maxPassengers = maxPassengers;
            }

            public override string ToString()
            {
                return $"The name of the ship is: {name} and maximum of passengers is: {maxPassengers}";
            }


        }

        class CargoShip:Ship
        {
            private int tonnageCapacity; 
            public CargoShip()
            { 
            }

            public CargoShip(string name, int tonnageCapacity):base(name)
            {
            this.tonnageCapacity = tonnageCapacity;

            }

            public CargoShip(int tonnageCapacity)
            {
                this.tonnageCapacity = tonnageCapacity;
            }

            public int getTonnageCapacity() {
                return tonnageCapacity;
            }

            public void setTonnageCapacity(int tonnageCapacity) {

                this.tonnageCapacity = tonnageCapacity;
            }

            public override string ToString()
            {
                return $"The name of the ship is: {name} and ship's cargo capacity is : {tonnageCapacity}";
            }

        }
        
    

    class Program
    {
        static void Main(string[] args)
        {
        
            Ship[] shipArray = new Ship[3];
         
            Ship s1 = new Ship("lodicka1", "1983");
            CruiseShip crS1 = new CruiseShip("cruiseLodicka1", 500);
            CargoShip caS1 = new CargoShip("cargoLodicka1", 50);

            shipArray[0] = s1;
            shipArray[1] = crS1;
            shipArray[2] = caS1;

            foreach (Ship item in shipArray)
            {
                Console.WriteLine( item.ToString());
            }

            Console.ReadLine();

        }
    }
}
