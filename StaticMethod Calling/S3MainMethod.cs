using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.StaticMethod
{
    internal class S3MainMethod
    {
        static void Main(string[] args)
        {
            Students4 stud= new Students4();
            
            stud.show();
            Students4.Output();
           
        }
    }
}
