using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConcept.PartialClass
{
    public partial class Calc // Dev 1 is working on File1 
    {
        public int add(int a,int b)
        {
            return a+ b;
        }
        public int sub( int c,int d)
        {
            return c - d;
        }
    }
}
/*When we work on large scale projects, we need to divide the task with multiple 
programmers/ developers so we can create multiple files with the same class 
name, and we will add partial keyword to the class, example is given below.*/
