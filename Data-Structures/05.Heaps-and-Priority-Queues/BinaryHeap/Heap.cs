using System;

public static class Heap<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        ConstructHeap(arr);

        for (int i = arr.Length - 1; i > 0; i--)
        {
            Swap(arr, 0, i);
            HeapifyDown(arr, 0, i);
        }
    }

    private static void ConstructHeap(T[] arr)
    {
        for (int i = arr.Length / 2; i >= 0; i--)
        {
            HeapifyDown(arr, i, arr.Length);
        }
    }


    private static void HeapifyDown(T[] arr, int index, int length)
    {
        while (index < length / 2)
        {
            int childIndex = (2 * index) + 1;
            if (childIndex + 1 < length && IsLess(arr, childIndex, childIndex + 1))
            {
                childIndex++;
            }

            if (!IsLess(arr, index, childIndex))
            {
                break;
            }

            Swap(arr, index, childIndex);
            index = childIndex;
        }
    }

    private static void Swap(T[] heap, int parent, int index)
    {
        T temp = heap[parent];
        heap[parent] = heap[index];
        heap[index] = temp;
    }

    private static bool IsLess(T[] heap, int left, int right)
    {
        return heap[left].CompareTo(heap[right]) < 0;
    }
}
