using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	public class QueueEnumertor<T> : IEnumerator<T>
	{
		int position = -1;
		T[] enumerableQueue;
		public QueueEnumertor(T[] initVal)
		{
			enumerableQueue = initVal;
		}
		public T Current
		{
			get
			{
				if (position == -1 || position >= (enumerableQueue.Length))
				{
					throw new InvalidOperationException();
				}
				return enumerableQueue[position];
			}
		}

		object IEnumerator.Current
		{
			get
			{
				if (position == -1 || position >= (enumerableQueue.Length))
				{
					throw new InvalidOperationException();
				}
				return enumerableQueue[position];
			}
		}

		public void Dispose()
		{

		}

		public bool MoveNext()
		{
			if (position < (enumerableQueue.Length - 1))
			{
				position++;
				return true;
			}
			else
				return false;

		}

		public void Reset()
		{
			position = -1;
		}
	}
	public class Queue<T>
	{
		int start, end;
		bool flag;
		const int capacity = 4;
		T[] queueArray;
		public Queue()
		{

			queueArray = new T[capacity];
			start = queueArray.Length - 1;
			end = queueArray.Length - 1;
			flag = false;
		}
		public T Peek()
		{
			if (queueArray[start] != null)
				return queueArray[start];
			else
			{
				return default(T);
				throw new Exception("Queue is empty");
			}
		}

		public void Enqueue(T i)
		{
			if (end != 0 && queueArray[end] == null && end != -1)
			{
				queueArray[end--] = i;

			}
			else
			{
				queueArray[end] = i;
				T[] arr1 = new T[queueArray.Length * 2];
				for (int j = 0; j < queueArray.Length; j++)
				{
					arr1[j] = queueArray[j];
				}
				queueArray = arr1;
				end = queueArray.Length - 1;
				flag = true;
			}
		}

		public T Dequeue()
		{
			if (start == -1)
			{
				start = queueArray.Length - 1;
			}
			if (queueArray[start] == null)
			{
				throw new Exception("The queue is empty");
			}
			else if (queueArray[start] != null)
			{
				T c = queueArray[start];
				queueArray[start--] = default(T);
				return c;
			}
			else return default(T);

		}
		public IEnumerator<T> GetEnumerator()
		{
			return new QueueEnumertor<T>(queueArray);
		}
	}
}
