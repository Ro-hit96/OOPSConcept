using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPSConcept.DelegatesProg.User;

namespace OOPSConcept.DelegatesProg
{
    public delegate String MyDelegate(string name);
    public class User
    {
       // public delegate String MyDelegate(string name); Declare Outside Class
        public String AcceptName(String name) 
        {

            name = name.ToUpper();
            return name;
        }

        public String AnatherName(String name)
        {
            name = name.ToLower();
            return name;
        }
    }

    public class ProgramMM
    {
        static void Main(string[] args)
        {
            User user = new User();
            MyDelegate myDelegate = new MyDelegate(user.AcceptName);
            myDelegate += new MyDelegate(user.AnatherName);

            //string str = myDelegate.Invoke("Rohit");
            //Console.WriteLine(str);

            Delegate[] list = myDelegate.GetInvocationList();
            foreach (Delegate V1 in list)

            {
                Console.WriteLine(V1.Method);
                string result = Convert.ToString(V1.DynamicInvoke("RohitSURVASE"));
                Console.WriteLine(result);
            }
        }
    }  }

