namespace _07.LinkedQueue
{
    using System;

    public class LinkedQueue<T> : ILinkedQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            var node = new QueueNode<T>(element);

            if (this.Count == 0)
            {
                this.tail = this.head = node;
            }
            else
            {
                node.PreviousNode = this.tail;
                this.tail.NextNode = node;
                this.tail = node;
            }
            
            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count <= 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            var queueHead = this.head.Value;
            if (this.Count == 1)
            {
                this.tail = null;
                this.head = null;
            }
            else
            {
                var newHead = this.head.NextNode;
                this.head.Value = default(T);
                this.head = newHead;
            }

            this.Count--;

            return queueHead;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            int index = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                arr[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }

        private class QueueNode<T2>
        {
            public QueueNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }

            public QueueNode<T> NextNode { get; set; }

            public QueueNode<T> PreviousNode { get; set; }
        }
    }
}
