using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle newCar = new Car("BlahMake", "SomeModel", 1990, "Brown");

            newCar.Year = 2001;
            newCar.Color = "Blue";
            Console.WriteLine(newCar.ToString());

            Vehicle newTruck = new Truck("TruckMake", "TruckModel", 1980, "Black", 2130);
            Console.WriteLine(newTruck.ToString());

            Console.ReadLine(); // Polling
        }
    }

    abstract class Vehicle {
        // Using prop
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract override string ToString();
    }

    class Car : Vehicle
    {
        public Car()
        {

        }

        public Car(string Make, string Model, int Year, string Color)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
        }

        // Shows scope
        private double getMarketValue()
        {
            double carValue = 100.0;
            if (this.Year > 2000)
            {
                carValue = 2000.0;
            }
            else
            {
                carValue = 200.0;
            }
            return carValue;
        }

        // Override toString
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} with {3:C} in market value",
                this.Make, this.Model, this.Color, this.getMarketValue());
        }
    }

    class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

        public Truck()
        {

        }

        public Truck(string Make, string Model, int Year, string Color, int TowingCapacity)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
            this.TowingCapacity = TowingCapacity;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} with {4} in towing units",
                this.Make, this.Model, this.Color, this.Year, this.TowingCapacity);
        }
    }
}
