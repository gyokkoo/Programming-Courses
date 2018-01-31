using System;
using System.Collections.Generic;

public class BinaryHeap<T> where T : IComparable<T>
{
    // Max binary heap
    private List<T> heap;

    public BinaryHeap()
    {
        this.heap = new List<T>();
    }

    public int Count
    {
        get
        {
            return this.heap.Count;
        }
    }
    
    public void Insert(T item)
    {
        this.heap.Add(item);
        this.HeapifyUp(this.heap.Count - 1);
        //this.HeapifyUpIterative(this.heap.Count - 1);

    }

    public T Peek()
    {
        if (this.heap.Count == 0)
        {
            throw new InvalidOperationException();
        }

        return this.heap[0];
    }

    public T Pull()
    {
        if (this.heap.Count <= 0)
        {
            throw new InvalidOperationException();
        }

        T element = this.heap[0];
        this.Swap(0, this.Count - 1);
        this.heap.RemoveAt(this.Count - 1);
        this.HeapifyDown(0);

        return element;
    }
    private void HeapifyUp(int index)
    {
        while (index > 0 && IsLess(ParentIndex(index), index))
        {
            this.Swap(index, ParentIndex(index));
            index = ParentIndex(index);
        }
    }
    
    private int ParentIndex(int index)
    {
        return (index - 1) / 2;
    }

    private void HeapifyUpIterative(int index)
    {
        int childIndex = index;
        T element = this.heap[index];
        int parentIndex = (index - 1) / 2;
        int compare = this.heap[parentIndex].CompareTo(element);
        while (parentIndex >= 0 && compare < 0)
        {
            this.Swap(parentIndex, childIndex);
            childIndex = parentIndex;
            parentIndex = (parentIndex - 1) / 2;
            compare = this.heap[parentIndex].CompareTo(element);
        }
    }

    private void Swap(int parent, int index)
    {
        T temp = this.heap[parent];
        this.heap[parent] = this.heap[index];
        this.heap[index] = temp;
    }

    private void HeapifyDown(int index)
    {
        while (index < this.Count / 2)
        {
            int childIndex = (2 * index) + 1;
            if (childIndex + 1 < this.Count && IsLess(childIndex, childIndex + 1))
            {
                childIndex++;
            }

            if (!IsLess(index, childIndex))
            {
                break;
            } 

            this.Swap(index, childIndex);
            index = childIndex;
        }
    }
    private bool IsLess(int left, int right)
    {
        return this.heap[left].CompareTo(this.heap[right]) < 0;
    }
    private bool IsGreater(int left, int right)
    {
        return this.heap[left].CompareTo(this.heap[right]) > 0;
    }
}
