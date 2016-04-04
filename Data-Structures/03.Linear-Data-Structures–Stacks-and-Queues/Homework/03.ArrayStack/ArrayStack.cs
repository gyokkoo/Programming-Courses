namespace _03.ArrayStack
{
    using System;

    public class ArrayStack<T> : IArrayStack<T>
    {
        private const int InitialCapacity = 16;

        private T[] elements;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count <= 0)
            {
                throw new InvalidOperationException("Invalid operation empty stack.");    
            }

            var element = this.elements[this.Count - 1];
            this.elements[this.Count - 1] = default(T);
            this.Count--;

            return element;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = this.elements[this.Count - i - 1];
            }

            return arr;
        }

        private void Grow()
        {
            var newElements = new T[this.Count * 2];
            Array.Copy(this.elements, newElements, this.Count);

            this.elements = newElements;
        }
    }
}
