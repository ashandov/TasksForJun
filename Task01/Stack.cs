using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    //Stack
   public class Stack
    {
       int top;
       const int capacity=4;
        public Stack()
       {
            top = 0;
            st = new int?[capacity];
        }
        private int?[] st;
        public int? Peek()
        {
            
                return st[top];
        }

        public void Push(int i)
        {
            if (top!=st.Length)
            {
                st[top++] = i;
            }
            else
            {
                int?[] st1 = new int?[st.Length * 2];
                for (int j = 0; j < st.Length; j++)
                {
                    st1[j] = st[j];
                }
                st = st1;
                st[top] = i;
            }
        }
        public int? Pop()
        {
            if (st[top] != null)
            {
                int? c = st[top];
                st[top] = null;
                return c;
            }
            else throw new Exception("Stack is empty");
        }
        public int Size { get { return st.Length; } }
    }
   
   
}
