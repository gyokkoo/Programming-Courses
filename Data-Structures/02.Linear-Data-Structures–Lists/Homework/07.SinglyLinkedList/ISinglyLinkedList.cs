namespace _07.SinglyLinkedList
{
    public interface ISinglyLinkedList<in T>
    {
        int Count { get; }

        void Add(T item);

        void Remove(int index);

        int FirstIndexOf(T item);

        int LastIndexOf(T item);
    }
}
