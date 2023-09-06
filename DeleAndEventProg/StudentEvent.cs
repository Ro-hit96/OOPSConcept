using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.DeleAndEventProg
{
    public delegate void MyDelegate();
    public class StudentEvent
    {
        //when event raise then notification will be sent to MyDelegate
        public event MyDelegate fail;   // Fail & pass are the event names
        public event MyDelegate pass;
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
    public class Message1
    {
        public void SuceessMessage()
        {
            Console.WriteLine("You Are pass in Exam");
        }
        public void FailMessage()
        {
            Console.WriteLine("You Are Fail in Exam");
        }
    }

    public class StudeMM
    {
        static void Main(string[] args)
        {
            try
            {
                StudentEvent stud = new StudentEvent();
                Message1 mess = new Message1();

                stud.fail += new MyDelegate(mess.FailMessage);
                stud.pass += new MyDelegate(mess.SuceessMessage);

                stud.AcceptPercentage(67);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
