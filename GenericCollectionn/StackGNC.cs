using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.GenericCollectionn
{
    public class StackGNC
    {
        static void Main(string[] args)
        {
            Stack<int>stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
           // stack.Pop();
            
            stack.Peek();

            Console.WriteLine("Top element " + stack.Peek());
            Console.WriteLine("Count of element is " + stack.Count());

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
