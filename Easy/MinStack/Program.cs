using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minstack = new MinStack();
            int min0 = minstack.GetMin();
            minstack.Push(2);
            minstack.Push(0);
            minstack.Push(3);
            minstack.Push(0);
            int min1 = minstack.GetMin();
            minstack.Pop();
            int min2 = minstack.GetMin();
            minstack.Pop();
            int min3 = minstack.GetMin();
            minstack.Pop();
            int min4 = minstack.GetMin();
            int top = minstack.Top();
        }
    }

    public class MinStack
    {
        private Stack<int> InternalStack;
        private int Min;
        /** initialize your data structure here. */
        public MinStack()
        {
            this.InternalStack = new Stack<int>();
        }

        public void Push(int x)
        {
            this.InternalStack.Push(x);
            if (x <= this.GetMin())
            {
                this.Min = x;
            }
        }

        public void Pop()
        {
            int topElement = this.InternalStack.Peek();
            this.InternalStack.Pop();
            if (this.GetMin() == topElement)
            {
                this.Min = topElement;
            }
        }

        public int Top()
        {
            return this.InternalStack.Peek();
        }

        public int GetMin()
        {
            return this.Min;
        }
    }

    public class MinStackTwo
    {
        private Stack<int> InternalStack;
        private Stack<int> MinValueStack;
        /** initialize your data structure here. */
        public MinStackTwo()
        {
            this.InternalStack = new Stack<int>();
            this.MinValueStack = new Stack<int>();
            this.MinValueStack.Push(int.MaxValue);
        }

        public void Push(int x)
        {
            this.InternalStack.Push(x);
            if(x <= this.GetMin())
            {
                this.MinValueStack.Push(x);
            }
        }

        public void Pop()
        {
            int topElement = this.InternalStack.Peek();
            this.InternalStack.Pop();
            if(this.GetMin() == topElement)
            {
                this.MinValueStack.Pop();
            }
        }

        public int Top()
        {
            return this.InternalStack.Peek();
        }

        public int GetMin()
        {
            if(this.MinValueStack.Count == 0)
            {
                return 0;
            }

            return this.MinValueStack.Peek();
        }
    }
}
