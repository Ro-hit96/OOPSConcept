using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class MethoLoad
    {

        public int add(int a,int b)
        {
            return a+b;
        }
        public void add(double v,double c)
        {
            double d = v + c;
          
        }
        public int add(int a,int b,int c)
        {
            return a+b+c;
        }
        
    }
    public class loadins
    {
        static void Main(string[] args)
        {
            MethoLoad m=new MethoLoad();
            m.add(1,2);
            m.add(22.2, 22);
            m.add(2,34,4);
        }
    }
}
