using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          * Todo follow all comments!! 
          */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car Tacoma = new Car() { HasTrunk = false, Make = "Toyota", Model = "Tacoma", Year = 2020 };
            Motorcycle Motorcycle = new Motorcycle() { HasSideCart = true, Make = "Harley", Model = "Black one", Year = 2022};

            Vehicle Truck1 = new Car() { Make = "Chevy", Model = "Silverado", Year = 2003 };
            Vehicle Truck2 = new Car() { Make = "Ford", Model = "Raptor", Year = 2016 };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(Tacoma);
            vehicles.Add(Motorcycle);
            vehicles.Add(Truck1);
            vehicles.Add(Truck2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"Make: {item.Make}\nModel: {item.Model}\nYear: {item.Year}\n");
                item.DriveVirtual();
                Console.WriteLine("\n");
                
            }
            // Call each of the drive methods for one car and one motorcycle

           

            #endregion
            Console.ReadLine();
        }
    }
}
