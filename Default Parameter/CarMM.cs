using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Default_Parameter
{

    internal class CarMM
    {
        static void Main(string[] args)
        {
            Car a = new Car("HondaCity",120000);
            //  Console.WriteLine(a.Print());
            a.Print();
        }
    }
}
