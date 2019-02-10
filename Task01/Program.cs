using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(3);
            st.Push(4);
            st.Push(5);
            st.Push(6);
            st.Push(7);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            st.Push(12);
            st.Push(42);
            Console.WriteLine("-------------------------------------------------------");
            Queue q = new Queue();
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            Console.WriteLine(q.Dequeue());
            q.Enqueue(14);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            q.Enqueue(22);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            q.Enqueue(42);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
            q.Enqueue(42);
            q.Enqueue(31);
            q.Enqueue(777);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());




        }
    }
}
