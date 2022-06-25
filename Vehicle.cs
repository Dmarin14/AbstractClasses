using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 0;
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("I am driving virtually");
        }
    }
}
