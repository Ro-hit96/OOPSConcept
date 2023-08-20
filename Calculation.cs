using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Calculation
    {
        public int Add(int a ,int b)
        {
            return a + b;
        }
        public int Add(int c,int d,int e)
        {
            return c + d + e;
        }
        public double Add(double f ,double g)
        {
            return f + g;
        }
        public double Add(double h,double j,double k)
        {
            return h + j + k;
        }

    }
}
