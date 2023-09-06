using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPSConcept.Static_Method
{
    public class StaticConstr
    {
        protected int no;
        public StaticConstr()
        {
            Console.WriteLine("Class Name");

        }
        static StaticConstr()
        {
            int count = 100;
            Console.WriteLine("Think Quotient");
        } 
    }
    public class StaticContructorMM
    {
        static void Main(string[] args)
        {
            StaticConstr obj= new StaticConstr();
            
        }
    }
}

