using System;
using System.Collections;

namespace CAStackUsingQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();

            #region Default Queue Process
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Dequeue();
            #endregion

            Console.ReadLine();
        }
    }
    public class Stack
    {
        public Queue queue1 = new Queue();
        public Queue queue2 = new Queue();

        public int curr_size;
        public Stack()
        {
            curr_size = 0;
        }

        public void Push(int x)
        {
            curr_size++;
            queue2.Enqueue(x);

            while(queue1.Count > 0)
            {
                var peekItem = queue1.Peek();
                queue2.Enqueue(peekItem);
                queue1.Dequeue();
            }

            Queue queue = queue1;
            queue1 = queue2;
            queue2 = queue;
        }

        public void Pop()
        {

            // if no elements are there in q1
            if (queue1.Count == 0)
                return;
            var dequeued = queue1.Dequeue();
            curr_size--;
        }

    }
}
