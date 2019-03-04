using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Queue<T>
    {
        private int start, end;
        private const int capacity = 4;
        private T[] queueArray;
        public Queue()
        {

            queueArray = new T[capacity];
            start = queueArray.Length - 1;
            end = queueArray.Length - 1;
        }
        public T Peek()
        {
            if (queueArray[start].Equals(default(T)))
            {
                throw new Exception("Queue is empty");
            }
            return queueArray[start];
        }

        public void Enqueue(T item)
        {
            if (end != 0 && queueArray[end] == null && end != -1)
            {
                queueArray[end--] = item;
            }
            else
            {
                queueArray[end] = item;
                T[] arr1 = new T[queueArray.Length * 2];
                int i = (arr1.Length - 1) / 2;
                for (int j = arr1.Length - 1; i >= 0; i--)
                {
                    if (queueArray[i] != null)
                    {
                        arr1[j--] = queueArray[i];
                        end = j;
                    }
                }
                queueArray = arr1;
                start = queueArray.Length - 1;
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

    }
}
