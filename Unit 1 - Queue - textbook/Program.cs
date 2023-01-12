using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Unit_1___Queue___textbook
{
    internal class Program
    {
        static void showQueue(Queue queueToView)
        {
            // show the stack
            Console.WriteLine("Current queue - Number of items: {0}", queueToView.Count);
            foreach (char ch in queueToView)
            {
                Console.WriteLine(ch + " ");
            }
            Console.WriteLine("\n"); // Escape character \n for new line
        }

        static void Main(string[] args)
        {
            char data;

            Queue q = new Queue();   // The 'new' operator creates a new instance of a type; in this case a new Queue type of variable

            showQueue(q); // call the showQueue PROCEDURE

            // add to queue
            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');

            showQueue(q);

            // remove from head - it should be an 'A'
            data = (char)q.Dequeue();
            Console.WriteLine("Dequeue the value at the front of the queue value: {0}\n", data);

            // add to queue
            q.Enqueue('D');

            showQueue(q);

            Console.ReadLine();
        }
    }
}
