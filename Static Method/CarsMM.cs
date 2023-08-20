using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Static_Method
{
    internal class CarsMM
    {
        static void Main(string[] args)
        {
            Car c=new Car("Breza",223);
            Console.WriteLine(c.Print());

            Car c2 = new Car("Toyoto",100);
            Console.WriteLine(c2.Print());
        }
    }
}
