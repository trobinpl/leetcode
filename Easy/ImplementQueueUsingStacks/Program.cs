using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementQueueUsingStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue obj = new MyQueue();
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj.Push(4);
            obj.Push(5);
            obj.Push(6);
            obj.Push(7);
            int param_2 = obj.Pop();
            int param_3 = obj.Peek();
            bool param_4 = obj.Empty();
        }
    }

    public class MyQueue
    {
        Dictionary<bool, Stack<int>> Stacks;
        bool Discriminator = false;

        private Stack<int> CurrentStack
        {
            get
            {
                return Stacks[Discriminator];
            }
        }

        private Stack<int> PreviousStack
        {
            get
            {
                return Stacks[!Discriminator];
            }
        }

        /** Initialize your data structure here. */
        public MyQueue()
        {
            this.Stacks = new Dictionary<bool, Stack<int>>()
            {
                { false, new Stack<int>() },
                { true, new Stack<int>() },
            };
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            Discriminator = !Discriminator;
            Stack<int> previousStack = PreviousStack;

            CurrentStack.Push(x);

            int stackCount = PreviousStack.Count;
            previousStack = ReverseStack(PreviousStack);

            for (int i = 0; i < stackCount; i++)
            {
                CurrentStack.Push(previousStack.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return this.CurrentStack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return this.CurrentStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return this.CurrentStack.Count == 0;
        }

        private Stack<int> ReverseStack(Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>();
            int stackCount = stack.Count;
            for (int i = 0; i < stackCount; i++)
            {
                temp.Push(stack.Pop());
            }
            return temp;
        }
    }
}
