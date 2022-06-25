using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Car : Vehicle
    {

        public bool HasTrunk { get; set; }




        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a car");
        }

        public Car()
        {

        }
    }
}
