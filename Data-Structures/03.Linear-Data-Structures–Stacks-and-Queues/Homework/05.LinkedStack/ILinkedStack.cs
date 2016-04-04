namespace _05.LinkedStack
{
    public interface ILinkedStack<T>
    {
        int Count { get; }

        void Push(T element);

        T Pop();

        T[] ToArray();
    }
}
