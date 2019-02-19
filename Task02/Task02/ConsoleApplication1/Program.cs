using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int?> st = new Stack<int?>();
			st.Push(3);
			st.Peek();
			st.Push(4);
			st.Push(5);
			st.Push(6);
			st.Push(7);
			foreach (var item in st)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine(st.Pop());
			Console.WriteLine(st.Peek());
			st.Push(12);
			st.Push(42);
			Console.WriteLine("-------------------------------------------------------");
			Queue<int?> q = new Queue<int?>();
			q.Enqueue(3);
			q.Enqueue(4);
			q.Enqueue(5);
			q.Enqueue(6);
			q.Enqueue(7);
			foreach (var item in q)
			{
				Console.Write(item + " ");
			}
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
			//Console.WriteLine(q.Peek());
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
