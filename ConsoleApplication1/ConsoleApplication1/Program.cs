using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a person object
            Person josh = new Person("Josh", 26, 130);

            //create our cars inventory
            List<Car> carInventory = new List<Car>(); 

            //create cities
            List<City> cities = new List<City>();

            City city1 = new City("New York City", 100);
            City city2 = new City("Chicago", 200);

            cities.Add(city1);
            cities.Add(city2);
            

            //add cars to the inventory
            Car car1 = new Car("volkswagon", "gti", 2015, 25000);
            Car car2 = new Car("mazda", "3", 2014, 20000);
            Car car3 = new Car("subaru", "impreza", 2015, 23000);

            carInventory.Add(car1);
            carInventory.Add(car2);
            carInventory.Add(car3);

            //invoke methods on the person object
            josh.personInfo();
            josh.workOut(50);

            //josh.buyCar("Volkswagon", "GTI", carInventory);
            josh.buyCar("3", "Mazda", carInventory);
            josh.viewCars();
            //josh.driveCar("Mazda", "3", cities, "Chicago");
            josh.driveCar("Mazda", "3", cities, "New York City");

            

            




            Console.ReadLine();

        }
    }
}
