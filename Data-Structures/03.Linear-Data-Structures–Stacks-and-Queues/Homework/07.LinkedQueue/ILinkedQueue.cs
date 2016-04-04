namespace _07.LinkedQueue
{
    public interface ILinkedQueue<T>
    {
        int Count { get; }

        void Enqueue(T element);

        T Dequeue();

        T[] ToArray();
    }
}