using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList<string> list = new LinkedList<string>();
			list.Add("First item");
			list.Add("Second item");
			list.Add("3rd item");
			list.AppendFirst("Append first element");
			list.Remove("Second item");
			Console.WriteLine(list.Contains("3rd item"));
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
	class LinkedList<T>	
	{
		private Item<T> head;
		private Item<T> tail;
		public int count;
		public LinkedList()
		{
			count = 0;

		}
		public void AppendFirst(T data)
		{
			Item<T> item = new Item<T>(data);
			if (head == null)
			{
				head = item;
				tail.Next = item;
				tail = head;
			}
			else
			{
				item.Next = head;
				head = item;
			}
			count++;

		}
		public void Add(T data)
		{
			Item<T> item = new Item<T>(data);
			if (head == null)
			{
				head = item;
			}
			else
			{
				tail.Next = item;
			}
			tail = item;
			count++;

		}
		public bool Remove(T data)
		{
			Item<T> current = head;
			Item<T> previous = null;
			while (current != null)
			{
				if (current.Data.Equals(data))
				{
					if (previous != null)
					{
						previous.Next = current.Next;
						if (current.Next == null)
						{
							tail = previous;
						}
					}
					else
					{
						head = head.Next;
					}
					if (head == null)
					{
						tail = null;
					}
					count--;
					return true;
				}
				previous = current;
				current = current.Next;
			}
			return false;
		}
		public bool Contains(T item)
		{
			Item<T> searchValue=head;
			while(searchValue!=null)
			{
			   if(searchValue.Data.Equals(item))
			   {
				return true;
			   }
				   searchValue = searchValue.Next;
			}
			return false;
		}
		public IEnumerator<T> GetEnumerator()
		{
			Item<T> current = head;
			while (current != null)
			{
				yield return current.Data;
				current=current.Next;
			}
		}
}
	class Item<T>
	{
		public T Data { get; set; }
		public Item(T data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("Constructor couldn't take null");
			}
			Data = data;
		}
		public Item<T> Next { get; set; }

	}
}
