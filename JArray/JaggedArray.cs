using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.JArray
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];
            jarray[0] = new int[3];
            jarray[1] = new int[4];
            jarray[2] = new int[2];

            for (int row = 0; row < jarray.Length; row++)
            {
                for (int col = 0; col < jarray[row].Length; col++)
                {
                    jarray[row][col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
        }  
    }
}
