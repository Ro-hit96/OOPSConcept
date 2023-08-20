using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Inheritance
{
    internal class Employee1MM
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager(200,"Rohit",24000);
            m1.CalculateSalary();
            Console.WriteLine(m1.Print());

            //Employees1 e1 = new Employees1( "Amit", 20000);
            //e1.CalculateSalary();
            //Console.WriteLine(e1.Print());

            //Employees1 e2 = new Manager(300, "Anata", 25000);
            //e2.CalculateSalary();
            //Console.WriteLine(e2.Print());

            Employees1 e3 = new SalesEmployee(1000, 2000, 300, "Rohit", 23000);
            e3.CalculateSalary();
            Console.WriteLine(e3.Print());
        }
    }
}
