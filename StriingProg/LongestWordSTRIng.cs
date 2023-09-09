using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.StriingProg
{
    public class LongestWordSTRIng
       	//WAP to find longest word in the given sentence
    {
        static void Main(string[] args)
        {
            string str = "India Win The WorldCup";
            string[] arr = str.Split(' ');
            int longwordlength = 0;
            String LongWord = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > longwordlength)
                {
                    longwordlength = arr[i].Length;
                    LongWord = arr[i];

                }
            }
            Console.WriteLine("Find Longest Word"+LongWord);

        }
    }
}
