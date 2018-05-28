using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStackUsingQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack obj = new MyStack();
            obj.Push(1);
            int param_2 = obj.Pop();
            int param_3 = -1;
            obj.Push(2);
            param_3 = obj.Top();
            obj.Push(3);
            param_3 = obj.Top();
            obj.Push(4);
            param_3 = obj.Top();
            obj.Push(5);
            obj.Push(6);
            obj.Push(7);
            obj.Push(8);
            obj.Push(9);
            int r = obj.Pop();
            r = obj.Pop();
            r = obj.Pop();
            r = obj.Pop();
            r = obj.Pop();
            r = obj.Pop();
            r = obj.Pop();

            bool param_4 = obj.Empty();
        }
    }

    public class MyStack
    {
        private Dictionary<int, Queue<int>> Queues;
        private int Discriminator;
        /** Initialize your data structure here. */
        public MyStack()
        {
            Discriminator = 0;
            Queues = new Dictionary<int, Queue<int>>()
            {
                {0, new Queue<int>() },
                {1, new Queue<int>() }
            };
        }

        private Queue<int> CurrentQueue
        {
            get
            {
                return Queues[Discriminator];
            }
        }

        private Queue<int> OldQueue
        {
            get
            {
                return Queues[1 - Discriminator];
            }
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            Discriminator = (Discriminator + 1) % 2;
            CurrentQueue.Enqueue(x);
            if(OldQueue.Count != 0)
            {
                int oldQueueCount = OldQueue.Count;
                for (int i=0; i< oldQueueCount; i++)
                {
                    CurrentQueue.Enqueue(OldQueue.Dequeue());
                }
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return CurrentQueue.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return CurrentQueue.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return CurrentQueue.Count == 0;
        }
    }
}
