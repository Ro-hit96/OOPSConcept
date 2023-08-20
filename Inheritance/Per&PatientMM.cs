using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Inheritance
{
    internal class Per_PatientMM
    {
        static void Main(string[] args)
        {
            //PersonAndPatient p1 = new PersonAndPatient("Rohit", 12334567, "Akurdi");
            //Console.WriteLine(p1.Display());

            //Patient p2 = new Patient("O", "Male", 20000, "Amit", 73737737373, "Nigadi");
            //Console.WriteLine(p2.Display());

            PersonAndPatient p3 = new Patient("A", "Female", 23232, "Aliya", 12121212, "Pimpari");
            Console.WriteLine(p3.Display());
        }
    }
}
