using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Exam
{
    internal class MethodOverLoad
    {
        static void Main(string[] args)
        {
            MethodOvMM m1 = new MethodOvMM();
            m1.Area(5);
           
            m1.Area(2, 5);
            m1.Area(3, 4, 5);           
            Console.ReadLine();

        }
    }
}
