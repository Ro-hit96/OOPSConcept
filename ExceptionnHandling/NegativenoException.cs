using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ExceptionnHandling
{
    //1.If number is negative then throw negative number exception.
    public class NegativenoException : Exception
    {
        public NegativenoException(string error):base(error)
        {
                
        }
    }
    public class user
    {
        public user(int no)
        {
            if (no < 0)
            {
                Console.WriteLine("Number is negative");
            }
            if (no == 0)
            {
                Console.WriteLine("No is Zero");
            }
                
        }
    }
    public class NegativeExcptionProgMM
    {
        static void Main(string[] args)
        {
            try
            {
                user u1 = new user(-1);
            }
            catch (NegativenoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                user u2 = new user(0);

            }
            catch(NegativenoException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
