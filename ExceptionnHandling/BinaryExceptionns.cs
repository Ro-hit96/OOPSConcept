using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ExceptionnHandling
{
    public class BinaryExceptionns:Exception
    {
        public BinaryExceptionns(string error) : base(error)
        {

        }
       
    }
    public class user6
    {
        public user6(string bin)
        {
            bool iseual = false;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] != '0' && bin[i] != '1')
                {
                    throw new BinaryExceptionns("not binary");
                    break;

                }
                else
                {
                    iseual = true;
                }
            }
            int decimalValue = 0;
            int binaryBase = 2;
            int exponent = 0;
            if (iseual)
            {
                for (int j = bin.Length - 1; j >= 0; j--)
                {
                    if (bin[j] == '1')
                    {
                        decimalValue += (int)Math.Pow(binaryBase, exponent);
                    }
                    exponent++;
                }
            }
            Console.WriteLine(decimalValue);
        }
    }

    public class BinaryProgMM
    {
        static void Main(string[] args)
        {
            try
            {
                user6 u=new user6("64737");
            }
            catch (BinaryExceptionns e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
