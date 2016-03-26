namespace _06.ReversedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ReversedList<T> : IReversedList<T>
    {
        private const int DefaultCapacity = 4;

        private T[] array;

        public ReversedList(int capacity)
        {
            this.array = new T[capacity];
            this.Capacity = capacity;
            this.Count = 0;
        }

        public ReversedList()
           : this(DefaultCapacity)
        {
        }

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public T this[int index]
        {
            get
            {
                return this.GetAtIndex(index);
            }

            set
            {
                this.ValidateIndex(index);

                this.array[this.Count - index - 1] = value;
            }
        }

        public void Add(T item)
        {
            this.CheckResize();

            this.array[this.Count] = item;
            this.Count++;
        }

        public void Remove(int index)
        {
            this.ValidateIndex(index);

            for (int i = this.Count - index - 1; i < this.Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.array[this.Count - 1] = default(T);
            this.Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        } 

        private void CheckResize()
        {
            if (this.Count >= this.Capacity - 1)
            {
                this.Capacity *= 2;

                T[] newArray = new T[this.Capacity];

                Array.Copy(this.array, newArray, this.array.Length - 1);

                this.array = newArray;
            }
        }

        private T GetAtIndex(int index)
        {
            this.ValidateIndex(index);

            return this.array[this.Count - index - 1];
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || this.Count <= index)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
        }
    }
}
