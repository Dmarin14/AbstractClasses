using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }




        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a motorcyle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I am driving this motorcyle");
        }

        public Motorcycle()
        {

        }
    }
}
