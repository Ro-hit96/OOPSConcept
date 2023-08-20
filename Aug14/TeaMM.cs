using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Aug14
{
    internal class TeaMM
    {
        static void Main(string[] args)
        {
           

            Teacher t1 = new TempTeacher(9, 25000,1001,"Sandesh");
            Console.WriteLine(t1.Display()); 
            
        }
    }
}
