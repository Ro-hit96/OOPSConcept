using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Ref_Keyword
{
    public class OutKeywords
    {
        public void Calculate(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = b - a;
        }
        public void Calculate(int a, out int sq, out double sqroot)
        {
            sq = a * a;
            sqroot = Math.Sqrt(a);
        }

      


        public static void Main(string[] args)
        {
            OutKeywords c = new OutKeywords();
            int a = 20, b = 5, sub, mul, sum;
            c.Calculate(a, b, out sum, out sub, out mul);
            Console.WriteLine("Sum is=" + sum);
            Console.WriteLine("Sub is=" + sub);
            Console.WriteLine("mul is =" + mul);

            int sq;
            double sqroot;
            c.Calculate(a, out sq, out sqroot);
            Console.WriteLine(sq);
            Console.WriteLine(sqroot);


        }
    }
}
