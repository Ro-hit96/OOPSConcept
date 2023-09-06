using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ExceptionnHandling
{
    public class Employe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            


            try
            {
                string name = Console.ReadLine();
               // string name = null;
               if(string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name is Required");
                }
                Console.WriteLine(name);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Inside the Finally block");
            }
           }

        }
    }

