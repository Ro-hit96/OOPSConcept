using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ExceptionnHandling
{
    public class NameExceptionn : Exception
    {
        public NameExceptionn(string error) : base(error)
        {

        }

    }
    public class Students
    {
        public Students(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("String is empty");
            } 
        }
    }

    public class NameExceptionPrgMM
    {
        static void Main(string[] args)
        {
            try
            {
                Students s1 = new Students(" ");
                
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
