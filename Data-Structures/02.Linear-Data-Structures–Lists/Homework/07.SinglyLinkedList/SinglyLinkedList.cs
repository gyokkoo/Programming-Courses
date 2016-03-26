namespace _07.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : ISinglyLinkedList<T>, IEnumerable<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; private set; }

        private ListNode<T> this[int index]
        {
            get
            {
                var currentIndex = 0;
                var currentNode = this.head;

                while (currentNode != null)
                {
                    if (currentIndex == index)
                    {
                        break;
                    }

                    currentIndex++;
                    currentNode = currentNode.NextNode;
                }

                return currentNode;
            }
        }

        public void Add(T item)
        {
            var newNode = new ListNode<T>(item);

            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                this.tail.NextNode = newNode;
                this.tail = newNode;
            }

            this.Count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || this.Count <= index)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var nextNode = this[index].NextNode;
                ListNode<T> previousNode = null;

                try
                {
                    previousNode = this[index - 1];
                }
                catch (IndexOutOfRangeException)
                {
                }

                if (previousNode == null)
                {
                    this.head = nextNode;
                }
                else
                {
                    previousNode.NextNode = nextNode;
                }
            }

            this.Count--;
        }

        public int FirstIndexOf(T item)
        {
            int index = 0;

            foreach (var value in this)
            {
                if (value.Equals(item))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public int LastIndexOf(T item)
        {
            int index = 0;
            int foundIndex = -1;

            foreach (var value in this)
            {
                if (value.Equals(item))
                {
                    foundIndex = index;
                }

                index++;
            }

            return foundIndex;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class ListNode<T>
        {
            public ListNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; private set; }

            public ListNode<T> NextNode { get; set; }
        }
    }
}