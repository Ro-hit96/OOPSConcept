using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Static_Method
{
    public struct Sturctclass
    {
        private int x, y;
        public Sturctclass(int X,int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public string Print()
        {
            return $"{x}and {y}";
        }

    }

    public class StructMM
    {
        static void Main(string[] args)
        {
            Sturctclass abc = new Sturctclass(10, 23);
            Console.WriteLine(abc.Print()); 
        }
    }
}
