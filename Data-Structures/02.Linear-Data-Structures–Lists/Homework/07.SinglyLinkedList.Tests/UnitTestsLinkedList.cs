namespace _07.SinglyLinkedList.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestsLinkedList
    {
        [TestMethod]
        public void Add_EmptyList_ShouldIncrementCount()
        {
            const int N = 100;
            var list = new SinglyLinkedList<int>();

            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }

            Assert.AreEqual(N, list.Count);
        }

        public void Add_EmptyList_ShouldAdd()
        {
            const int N = 100;
            var list = new SinglyLinkedList<int>();

            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }

            int currentItem = 0;
            foreach (var item in list)
            {
                Assert.AreEqual(currentItem, item);
                currentItem++;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_InvalidIndex_ShouldThrow()
        {
            var list = new SinglyLinkedList<int>();

            list.Remove(0);
        }

        [TestMethod]
        public void Remove_ValidIndex_ShouldDecrementCount()
        {
            const int N = 100;
            var list = new SinglyLinkedList<int>();

            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }

            list.Remove(0);
            list.Remove(1);
            list.Remove(2);

            Assert.AreEqual(N - 3, list.Count);
        }

        [TestMethod]
        public void Remove_ValidIndex_ShouldRemove()
        {
            const int N = 100;
            var list = new SinglyLinkedList<int>();

            for (int i = 0; i < N; i++)
            {
                list.Add(i);
                list.Remove(0);
            }

            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void FirstIndexOf_ExistingItem_ShouldReturnCorrectIndex()
        {
            var list = new SinglyLinkedList<int>();
        
            list.Add(1);
            list.Add(101);
            list.Add(1);
            list.Add(101);
        
            var index = list.FirstIndexOf(1);
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        public void FirstIndexOf_NonExistingItem_ShouldReturnMinusOne()
        {
            var list = new SinglyLinkedList<int>();

            list.Add(1);
            list.Add(101);
            list.Add(1);
            list.Add(101);

            var index = list.FirstIndexOf(1001);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void LastIndexOf_ExistingItem_ShouldReturnCorrectIndex()
        {
            var list = new SinglyLinkedList<int>();

            list.Add(1);
            list.Add(101);
            list.Add(1);
            list.Add(101);

            var index = list.LastIndexOf(1);
            Assert.AreEqual(2, index);
        }

        [TestMethod]
        public void LastIndexOf_NonExistingItem_ShouldReturnMinusOne()
        {
            var list = new SinglyLinkedList<int>();

            list.Add(1);
            list.Add(101);
            list.Add(1);
            list.Add(101);

            var index = list.LastIndexOf(1001);
            Assert.AreEqual(-1, index);
        }
    }
}
