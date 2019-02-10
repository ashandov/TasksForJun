using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Queue
    {
        int start,end;
        bool flag;
        const int capacity = 4;
        int?[] arr;
        public Queue()
        {
           
            arr = new int?[capacity];
            start = arr.Length-1;
            end = arr.Length-1;
            flag = false;
        }
        public int? Peek()
        {
            if(arr[start]!=null)
            return arr[start];
            else 
            {
                return null;
                throw new Exception("Queue is empty");
            }
        }

        public void Enqueue(int i)
        {
            if (end !=0 && arr[end]==null && end!=-1)
            {
                    arr[end--] = i;
             
            }
            else
            {
                    arr[end] = i;
                    int?[] arr1 = new int?[arr.Length * 2];
                    for (int j = 0; j < arr.Length; j++)
                    {
                        arr1[j] = arr[j];
                    }
                    arr = arr1;
                    end = arr.Length - 1;
                    flag = true;
            }
        }

        public int? Dequeue()
        {
            if (start == -1)
            {
                start = arr.Length - 1;
            }
            if (arr[start] == null)
            {
                throw new Exception("The queue is empty");
            }
            else if (arr[start] != null)
            { 
                int? c = arr[start];
               arr[start--] = null;             
                    return c;
            }
            else return null;

        }
    }
}