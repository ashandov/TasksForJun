using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	public class StackEnumertor<T> : IEnumerator<T>
	{
		int position = -1;
		T[] enumerableStack;
		public StackEnumertor(T[] initVal)
		{
			enumerableStack = initVal;
		}

		public T Current
		{
			get
			{
				if (position == -1 || position >= (enumerableStack.Length))
				{
					throw new InvalidOperationException();
				}
				return enumerableStack[position];
			}
		}

		object IEnumerator.Current
		{
			get
			{
				if (position == -1 || position >= (enumerableStack.Length))
				{
					throw new InvalidOperationException();
				}
				return enumerableStack[position];
			}
		}

		public void Dispose()
		{

		}

		public bool MoveNext()
		{
			if (position < (enumerableStack.Length - 1))
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
	public class Stack<T>
	{
		int top;
		const int capacity = 4;
		private T[] stackArray;
		public Stack()
		{
			top = 0;
			stackArray = new T[capacity];
		}
		public int Size { get { return stackArray.Length; } }
		public T Peek()
		{
			if (top - 1 < 0) { throw new IndexOutOfRangeException("Negative index"); }
			T c = stackArray[top - 1];
			stackArray[--top] = default(T);
			return c;
		}

		public void Push(T i)
		{
			if (top < stackArray.Length - 1)
			{
				stackArray[top++] = i;
			}
			else
			{
				T[] st1 = new T[stackArray.Length * 2];
				for (int j = 0; j < stackArray.Length; j++)
				{
					st1[j] = stackArray[j];
				}
				stackArray = st1;
				stackArray[top] = i;
			}
		}
		public T Pop()
		{
			if (top - 1 < 0) { throw new IndexOutOfRangeException("Negative index"); }
			T c = stackArray[top - 1];
			stackArray[--top] = default(T);
			return c;
		}
		public IEnumerator<T> GetEnumerator()
		{
			return new StackEnumertor<T>(stackArray);
		}

	}


}
