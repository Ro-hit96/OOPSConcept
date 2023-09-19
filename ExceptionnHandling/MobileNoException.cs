using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ExceptionnHandling
{
    //WAP to take mobile number  in String from user 
    //a)if it is content number of digit less than 10 or more than 10
    //then throw Exception.
    public class MobileNoException: Exception
    {  
        public MobileNoException(string error): base(error)
        {
                
        }
    }
    public class user2
    {
        public user2(string no)
        {
               for (int i = 0; i > no.Length; i++)
            {
                if(no.Length > 10 || no.Length < 10 || (no[i] >= 'a' && no[i] <= 'z') || (no[i] >= 'A' && no[i] <= 'Z'))
                {
                    throw new MobileNoException("Invalid NO");
                }
            } 
        }
    }

    public class MobileExceptionProgMM
    {
        static void Main(string[] args)
        {
            try
            {
                user2 u2 = new user2("8329682341");
            }
            catch(MobileNoException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
