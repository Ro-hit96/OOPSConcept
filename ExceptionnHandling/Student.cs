using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ExceptionnHandling
{
    public class NameException:Exception
    {
        public NameException(string error):base(error)
        {

        }
    }
    public class Student
    {
        public Student(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("String is emplty");
            }
        }
    }

    internal class program 
    {
        static void Main(string[] args)
        {
            try
            {
                Student stu = new Student("");
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
