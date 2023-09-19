using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ExceptionnHandling
{
    //2.WAP to check String content only alphabets if any digit or symbol is present then throw custom exception

    public class DigitSymbolException:Exception
    {
        public DigitSymbolException(string error):base(error)
        {
            
        }
    }
    public class user4
    {
        public user4(string str)
        {
             for(int i = 0; i < str.Length; i++)
            {
                if((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    string str1 = null;
                }
                else
                {
                    throw new DigitSymbolException("you have enter the symbol Or Digit");
                    break;
                }
            }
            
        }
    }

    public class DigitorsymProgMM
    {
        static void Main(string[] args)
        {
            try
            {
                user4 u = new user4("Symb&*");
            }
            catch(DigitSymbolException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
