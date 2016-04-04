namespace _03.ArrayStack
{
    public interface IArrayStack<T>
    {
        int Count { get; }

        void Push(T element);

        T Pop();

        T[] ToArray();
    }
}