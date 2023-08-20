using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Exam
{ 
    // Write Code to overload the method area to calculate area of circle ,square,rectangle and triangle
    public class MethodOvMM
    {
        public double pi = 3.14;
       public double Area(int r)
        {
            double  circle = pi * r * r;
            Console.WriteLine("Area of Circle="+circle);
            return circle;
        }
        public int Area(int a,int b)
        {
            int square = a*b;
            Console.WriteLine("Area of Square="+square);
            return square;
        }
        public float Area (int l,float b )
        {
            float Rectangle = l * b;
            Console.WriteLine("Area of Rectangle="+Rectangle);
            return Rectangle;
        }
        public double Area(double l,double b,double h)
        {
            double Triangle = l * b * h/2;
            Console.WriteLine("Area of Triangle"+Triangle);
            return Triangle;
        }

    }
}
