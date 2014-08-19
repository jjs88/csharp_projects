using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Car
    {
        //public properties
        public string model { get; set; }
        public string make { get; set; }
        public int year { get; set; }
        public int price { get; set; }

        //private properties
        private double gasTank = 100.00;

        //constructors
        public Car(string make, string model, int year, int price)
        {
            this.model = model;
            this.make = make;
            this.year = year;
            this.price = price;
        }

        
        //methods
        public void accelerate(double distance, string cityName) //probably need to name this method better
        {
            if (gasCheck(distance) == 0)
            {
                Console.WriteLine("Driving to destination: {0}", cityName);
                Console.WriteLine("Gas left in tank: {0}", gasTank);
            }
        }

        
        private int gasCheck(double distance)
        {
            double gasAmount = distance * .40;

            if (gasTank - gasAmount <= 0)
            {
                Console.WriteLine("You don't have enough gas to get to your destination");
                return 1;
            }
            else
            {

                gasTank = gasTank - gasAmount;
                return 0;
            }
            
        }

    }
}
