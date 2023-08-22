using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.JArray
{
    public class Employee
    {
        public int eid { get; set; }
        public string ename { get; set; }

        public int eSalary { get; set; }

        public int eage { get; set; }
    }

    public class EmpMM
    {
        static void Main(string[] args)
        {
            Employee[] elist = new Employee[4]
            {
                new Employee{eid=1, ename="Rohit",eSalary=25000,eage=23},
                new Employee{eid=2, ename="Amit",eSalary=1000,eage=21},
                new Employee{eid=3, ename="Sunny",eSalary=63773,eage=22},
                new Employee{eid=4, ename="vicky",eSalary=26633,eage=19},

            };
            foreach (Employee el in elist)
            {
                Console.WriteLine($"id={ el.eid} name={ el.ename} esalary={ el.eSalary} eage={ el.eage}");
            }
        }
    }
}
