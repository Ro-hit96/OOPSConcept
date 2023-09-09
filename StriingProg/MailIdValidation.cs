using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.StriingProg
{
    public class MailIdValidation
    {
        //  Accept email_id from user and check valid or not(should contain @,.)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email Id");
            string str = Console.ReadLine();
            bool Isvalid = false;
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '@' || ch[i] == '.')
                {
                    Isvalid = true;

                }  
            }
            if(Isvalid = true)
            {
                Console.WriteLine("Valid");

            }
            else
            {
                Console.WriteLine("Not Valid");
            }
           
           
            
            
            






        }
    }
}
