using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.GenericCollectionn
{
    public class QueueGNC
    {
        static void Main(string[] args)
        {
            Queue<int>que = new Queue<int>();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            //que.Dequeue(); //Remove Top Element
            que.Clear();// Clear Queue Element

            Console.WriteLine("Queue "+que.Peek());
            Console.WriteLine("Queue Count is = "+que.Count);

            foreach (int item in que)
            {
                Console.WriteLine(item);
            }
        }
    }
}
