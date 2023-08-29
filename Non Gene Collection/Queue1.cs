using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOPSConcept.Collection
{
    public class Queue1
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(10);//add in to the queue
            que.Enqueue(20);
            que.Enqueue(30);
            que.Enqueue(40);

            que.Dequeue();//remove element from the queue

            Console.WriteLine("First element in que"+que.Peek());

            foreach(var item in que)
            {
                Console.WriteLine(item);
            }

        }
    }
}
