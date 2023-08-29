using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOPSConcept.Collection
{
    public class Stack1
    {
        static void Main(string[] args)
        {
            Stack stack=new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
          //  stack.Pop();//Remove the top element
           //stack.Peek();//Return the top element in the stack
            Console.WriteLine("Top element"+stack.Peek());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
