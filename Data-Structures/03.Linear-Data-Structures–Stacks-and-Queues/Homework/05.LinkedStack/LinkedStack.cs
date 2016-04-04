namespace _05.LinkedStack
{
    using System;

    public class LinkedStack<T> : ILinkedStack<T>
    {
        private Node<T> firstNode; 

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.Count == 0)
            {
                this.firstNode = new Node<T>(element);
            }
            else
            {
                this.firstNode = new Node<T>(element, this.firstNode);
            }

            this.Count++;
        }

        public T Pop()
        {
            if (this.Count <= 0)
            {
                throw new InvalidOperationException("Invalid operation stack is empty.");
            }

            var removedElement = this.firstNode.Value;
            this.firstNode.Value = default(T);
            this.firstNode = this.firstNode.NextNode;
            this.Count--;

            return removedElement;
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];

            int index = 0;
            var currentNode = this.firstNode;
            while (currentNode != null)
            {
                arr[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }

        private class Node<T2>
        {
            public Node(T2 value, Node<T2> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }

            public T2 Value { get; set; }

            public Node<T2> NextNode { get; }
        }
    }
}
