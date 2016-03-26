namespace _06.ReversedList.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestsReversedList
    {
        [TestMethod]
        public void Add_EmptyList_ShouldAddElement()
        {
            var list = new ReversedList<int>();

            list.Add(1);

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void Add_NonEmptyList_ShouldAddAndResizeCapacity()
        {
            var list = new ReversedList<int>(4) { 1, 2, 3 };

            list.Add(2);

            Assert.AreEqual(8, list.Capacity);
        }

        [TestMethod]
        public void GetIndex_ValidIndex_ShouldReturnValueReversed()
        {
            const int N = 1000;
            var list = new ReversedList<int>();

            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < N; i++)
            {
                var actualValue = list[i];
                Assert.AreEqual(N - i - 1, actualValue);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetIndex_InvalidPositiveIndex_ShouldThrow()
        {
            var list = new ReversedList<int>();

            var value = list[5];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetIndex_EmptyListZeroIndex_ShouldThrow()
        {
            var list = new ReversedList<int>();

            var value = list[0];
        }

        [TestMethod]
        public void SetIndex_ValidIndex_ShouldSetCorrectly()
        {
            const int Value = 1000;
            var list = new ReversedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            list[0] = Value;
            list[2] = Value;

            Assert.AreEqual(Value, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(Value, list[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SetIndex_InvalidIndex_ShouldThrow()
        {
            var list = new ReversedList<int>();

            list[0] = 1;
        }

        [TestMethod]
        public void Remove_ValidIndex_ShouldRemoveCorrectly()
        {
            var list = new ReversedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.Remove(2);

            Assert.AreEqual(4, list.Count);
            CollectionAssert.AreEqual(new List<int> { 5, 4, 2, 1 }, list.ToList());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_InvalidIndex_ShouldThrow()
        {
            var list = new ReversedList<int>();

            list.Add(1);
            list.Add(101);

            list.Remove(2);
        }
    }
}