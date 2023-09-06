using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.DeleAndEventProg
{
    public delegate void MyDelegate1();
    public class StudenAnonymous

    {
        public event MyDelegate1 fail;   // Fail & pass are the event names
        public event MyDelegate1 pass;
        public void AcceptPercentage(double percentage)
        {
            if (percentage < 40)
            {
                fail();
            }
            else
            {
                pass();
            }
        }

    }
    public class StudenAnoMM
    {
        static void Main(string[] args)
            
        {
            try
            {
                StudenAnonymous stud6 = new StudenAnonymous();
                stud6.fail += delegate () { Console.WriteLine("You are faid"); };
                stud6.pass += delegate () { Console.WriteLine("You are Pass"); };
                stud6.AcceptPercentage(70);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
