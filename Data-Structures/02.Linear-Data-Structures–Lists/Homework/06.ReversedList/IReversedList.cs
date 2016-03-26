namespace _06.ReversedList
{
    using System.Collections.Generic;

    public interface IReversedList<T> : IEnumerable<T>
    {
        int Count { get; }

        int Capacity { get; }

        T this[int index] { get; set; }

        void Add(T element);

        void Remove(int index);
    }
}