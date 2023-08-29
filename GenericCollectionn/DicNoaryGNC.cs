using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.GenericCollectionn
{
    public class DicNoaryGNC
    {
        static void Main(string[] args)
        {
            Dictionary<string,string>dic=new Dictionary<string,string>();
            dic.Add("..docx", "WordFile");
            dic.Add(".xls", "Excel File");
            dic.Add(".cs", "C#File");

            foreach(KeyValuePair<string,string> item in dic)
            {
                Console.WriteLine($"{item.Key}  {item.Value}");
            }
            Console.WriteLine("*********************************************************************");

            Dictionary<int,string>dic2= new Dictionary<int,string>();
            {
                dic2.Add(2000, "Watch");
                dic2.Add(3000, "Headphone");
                dic2.Add(4000, "Shoes");

                dic2.Remove(2000);

                foreach (KeyValuePair<int,string> item in dic2)
                {
                   Console.WriteLine($"{item.Key}  {item.Value}");
                }
                Console.WriteLine("_________________________________________________________________________");
            }

            Dictionary<int, string> City = new Dictionary<int, string>();
            {
                City.Add(91,"India");
                City.Add(81, "Austrelia");
                City.Add(71, "Pakistan");

                foreach (KeyValuePair<int,string> item in City)
                {
                    Console.WriteLine($"{item.Key}  {item.Value}");
                }
            }
        }
    }
}
