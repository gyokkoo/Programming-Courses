using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericList
{
    [Version(2, 4)]

    public class GenericList<T> where T : IComparable<T>
    {
        const int DefaultCapacity = 16;
        private T[] elements;
        private int currentIndex;
        private int initialCapacity;

        public GenericList(int initialCapacity = DefaultCapacity)
        {
            this.InitialCapacity = initialCapacity;
            this.elements = new T[initialCapacity];
            this.currentIndex = 0;
        }

        public int InitialCapacity
        {
            get { return this.initialCapacity; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("capacity", "initialCapacity cannot be negative");
                }

                this.initialCapacity = value;
            }
        }


        public void Add(T elementToAdd)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.currentIndex] = elementToAdd;
            this.currentIndex++;
        }

        private void Resize()
        {
            var newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < this.currentIndex; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        public int IndexOf(T elementToFind)
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty");
            }

            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[i].Equals(elementToFind))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T elementToInsert)
        {
            if (this.currentIndex == index)
            {
                this.Add(elementToInsert);
                return;
            }

            if (index < 0 || index >= this.currentIndex)
            {
                throw new ArgumentOutOfRangeException("Index was outside the boundaries of the GenericList");
            }

            if (this.currentIndex > this.initialCapacity)
            {
                this.Resize();
            }

            for (int i = this.currentIndex; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = elementToInsert;
            this.currentIndex++;
        }

        public void Remove(T elementToRemove)
        {
            int index = this.IndexOf(elementToRemove);

            if (index == -1)
            {
                throw new ArgumentException("Specified element was not found.");
            }

            for (int i = 0; i < this.currentIndex; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.currentIndex--;
            this.elements[currentIndex] = default(T);
        }

        public void Clear()
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                this.elements[i] = default(T);
            }

            this.currentIndex = 0;
        }

        public bool Contains(T searchElement)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[i].Equals(searchElement))
                {
                    return true;
                }
            }

            return false;
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new ArgumentOutOfRangeException("Index was outside the boundaries of the GenericList");
                }

                return this.elements[i];
            }

            set
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new ArgumentOutOfRangeException("Index was outside the boundaries of the GenericList");
                }

                this.elements[i] = value;
            }
        }

        public T GetAtIndex(int index)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new ArgumentOutOfRangeException("Index was outside the boundaries of the GenericList");
            }

            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[index].Equals(this.elements[i]))
                {
                    return elements[i];
                }
            }

            return default(T);
        }

        public T Max()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty");
            }

            T maxElement = this.elements[0];

            for (int i = 0; i < this.currentIndex; i++)
            {
                if (maxElement.CompareTo(this.elements[i]) < 0)
                {
                    maxElement = this.elements[i];
                }
            }

            return maxElement;
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty");
            }

            T minElement = this.elements[0];

            for (int i = 0; i < this.currentIndex; i++)
            {
                if (minElement.CompareTo(this.elements[i]) > 0)
                {
                    minElement = this.elements[i];
                }
            }

            return minElement;
        }

        public override string ToString()
        {
            return string.Format("[{0}]", string.Join(", ", this.elements.Take(currentIndex)));
        }
    }
}
