using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Exam
{
    internal class ConstructorOverMM
    {
        static void Main(string[] args)
        {
            ConstrcutorOverloading s1 = new ConstrcutorOverloading();
            ConstrcutorOverloading s2 = new ConstrcutorOverloading(8329672535, 21);
            ConstrcutorOverloading s3 = new ConstrcutorOverloading(23000);

            Console.WriteLine(s1.Print());
        }
    }
}
