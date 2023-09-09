using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.StriingProg
{
    public class Mobile_No_Validation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile No");
            string str = Console.ReadLine();
            bool IsValid=false;
            Char[] ch= str.ToCharArray();
            for(int i=0;i< ch.Length; i++)
            {
                if (ch[i]==0 && ch[i] == 0)
                {
                    IsValid = true;
                }
            }
            if (IsValid = true)
            {
                Console.WriteLine("No is Valid");

            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            
        }
    }
}
