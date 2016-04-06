namespace Trees
{
    using System;

    public class BinaryTree<T>
    {
        public BinaryTree(
            T value, 
            BinaryTree<T> leftChild = null, 
            BinaryTree<T> rightChild = null)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public T Value { get; set; }

        public BinaryTree<T> LeftChild { get; set; }

        public BinaryTree<T> RightChild { get; set; }

        public void PrintIndentedPreOrder(int indent = 0)
        {
            // Pre-order == root node, left child, right child
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.Value);
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintIndentedPreOrder(indent + 1);
            }

            if (this.RightChild != null)
            {
                this.RightChild.PrintIndentedPreOrder(indent + 1);
            }
        }

        public void EachInOrder(Action<T> action)
        {
            // In-order = left child, root node, right child
            if (this.LeftChild != null)
            {
                this.LeftChild.EachInOrder(action);
            }

            action(this.Value);

            if (this.RightChild != null)
            {
                this.RightChild.EachInOrder(action);
            }
        }

        public void EachPostOrder(Action<T> action)
        {
            // Post-order == left child, right child, root node
            if (this.LeftChild != null)
            {
                this.LeftChild.EachPostOrder(action);
            }

            if (this.RightChild != null)
            {
                this.RightChild.EachPostOrder(action);
            }

            action(this.Value);
        }
    }
}
