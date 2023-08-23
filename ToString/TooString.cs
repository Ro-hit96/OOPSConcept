using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ToString
{
    public class TooString
    {
        static void Main(string[] args)
        {
            string message = "HELLO TO ALL";
            string message2 = "hello #to all";

            //Method of string class
            string str1 = string.Concat(message,"  ", message2.TrimEnd());
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());

            Console.WriteLine(message2.ToUpper());
            Console.WriteLine(message.ToLower());
            Console.WriteLine("index-" + message2.IndexOf('o')); 
            Console.WriteLine("last index "+message2.LastIndexOf("o"));
            // convert string to string array

          //  string str2 = message2.Split('#');

        }
    }
}
