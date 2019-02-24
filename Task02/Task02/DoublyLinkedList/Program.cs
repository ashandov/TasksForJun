using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			DoblyLinkedList<int> list = new DoblyLinkedList<int>();
			list.Add(3);
			list.Add(4);
			list.Add(5);
			list.Add(6);
			list.Add(7);
			list.Remove(3);
			list.AppendFirst(1);
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
	public class DoublyNode<T>
	{
		public DoublyNode(T data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("Constructor couldn't take null");
			}
			Data = data;
		}
		public T Data { get; set; }
		public DoublyNode<T> Next { get; set; }
		public DoublyNode<T> Previous { get; set; }

	}
	class DoblyLinkedList<T>
	{
		private DoublyNode<T> head;
		private DoublyNode<T> tail;
		private int count;
		public DoblyLinkedList()
		{
			count = 0;
		}
		public int Count { get { return count; } }
		public void AppendFirst(T item)
		{
			DoublyNode<T> data = new DoublyNode<T>(item);
			if (head != null)
			{
				head.Previous = data;
				data.Next = head;
				head = data;
			}
			else
			{
				head = data;
				tail = data;
			}
			count++;
		}
		public void Add(T data)
		{
			DoublyNode<T> item = new DoublyNode<T>(data);
			if (head == null)
			{
				head = item;
			}
			else
			{
				tail.Next = item;
				item.Previous = tail;
			}
			tail = item;

			count++;
		}
		public bool Remove(T data)
		{
			DoublyNode<T> current = head;
			DoublyNode<T> previous = null;

			DoublyNode<T> item = new DoublyNode<T>(data);
			while (current != null)
			{
				if (current.Data.Equals(item.Data))
				{
					if (previous == null)
					{
						head = head.Next;
						head.Previous = null;
					}
					else
					{
						if (current.Next == null)
						{
							tail = previous;
						}
						else
						{
							current.Next.Previous = previous;
						}
						previous.Next = current.Next;


					}
					count--;
					return true;
				}
				else
				{
					previous = current;
					current = current.Next;
				}
			}
			return false;
		}
		public IEnumerator<T> GetEnumerator()
		{
			DoublyNode<T> item = head;
			while (item != null)
			{
				yield return item.Data;
				item = item.Next;
			}
		}

	}
}

