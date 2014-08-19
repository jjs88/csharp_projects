using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Person
    {
        //properties
        public string name { get; set; }
        public int age { get; set; }
        public int weight {get; set;}

        List<Car> myCars = new List<Car>(); 

        //private
        private int calories;
        private int burntCalories;
        private int cash = 35000;

        //constructors
        public Person(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.calories = age * weight;
        }

        
        //methods
        public void personInfo()
        {
            Console.WriteLine(name + ":" + age);
        }

        public void workOut(int time)
        {

            Console.WriteLine("starting calories before workout: {0}", calories);
            Console.WriteLine("You are working out for: {0} minutes.", time);

            if (calories <= 1000)
            {
                Console.WriteLine("Eat more food before working out. You might pass out!");
            }
            else
            {
                burntCalories = (time * 20);
                calories = calories - burntCalories;

                Console.WriteLine("Calories burnt: {0},", burntCalories);
                Console.WriteLine("Calories after workout: {0}", calories);
            }
        }

        
        public void buyCar(string model, string make, List<Car> cars)
        {
            Car c = cars.Find( x => x.make.Equals(make.ToLower()) && x.model.Equals(model.ToLower()));

            if (c != null && c.price <= cash)
            {
             myCars.Add(c);
             cash = cash - c.price;
             Console.WriteLine("Congratulations {0}!, you have purchased the following vehicle: {1} {2}. " +
                                "You have {3} remaining in your account", name, c.make, c.model, cash);
            }
            else
            {
                Console.WriteLine("Sorry there {0}, Car {1} {2} is not in the inventory or you don't have enough money!", name, model, make);
            }
        }

        public void viewCars()
        {

            if (myCars.Count != 0)
            {
                foreach (Car myCar in myCars)
                {
                    Console.WriteLine("You own: {0} {1} {2}", myCar.make, myCar.model, myCar.year);
                }
            }
            else
            {
                Console.WriteLine("Sorry dude, you don't own any cars. Are you still riding around on a bicycle?");
            }
        }

        public void driveCar(string make, string model, List<City> cities, string cityName)
        {
            Car c = myCars.Find(x => x.make.Equals(make.ToLower()) && x.model.Equals(model.ToLower()));
            City city = cities.Find(x => x.name.Equals(cityName));

            if (c != null)
            {
                if (city != null)
                {
                    c.accelerate(city.distance, city.name);
                }
                else
                {
                    Console.Write("Can't find city. Keep dreaming!");
                }
            }
            else
            {
                Console.WriteLine("can't find car.");
            }
        }

    }
}
