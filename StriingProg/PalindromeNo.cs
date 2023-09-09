using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class PalindromeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int num = Convert.ToInt32(Console.ReadLine());
            int pal = num;
            int rev = 0;

            while (num != 0)
            {
                int temp = num % 10;
                rev = (rev * 10) + temp;
                num=num / 10;
        
            }
            Console.WriteLine(rev);
            if (rev == pal)
            {
                Console.WriteLine("no is palindrome");
            }
            else
            {
                Console.WriteLine("no is not palindrome");
            }
        }
    }
}
