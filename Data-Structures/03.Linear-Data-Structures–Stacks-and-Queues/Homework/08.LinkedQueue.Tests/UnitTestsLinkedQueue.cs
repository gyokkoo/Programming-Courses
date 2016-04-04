namespace _08.LinkedQueue.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using _07.LinkedQueue;

    [TestClass]
    public class UnitTestsLinkedQueue
    {
        [TestMethod]
        public void Count_EmptyQueue_ShouldBeZero()
        {
            var stack = new LinkedQueue<int>();

            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Enqueue_EmptyQueue_ShouldAddElement()
        {
            var queue = new LinkedQueue<int>();

            queue.Enqueue(5);

            Assert.AreEqual(1, queue.Count);
        }

        [TestMethod]
        public void EnqueueDequeue_TypeString_ShouldWorkCorrectly()
        {
            var queue = new LinkedQueue<string>();
            var element = "some value";

            queue.Enqueue(element);
            var elementFromQueue = queue.Dequeue();

            Assert.AreEqual(0, queue.Count);
            Assert.AreEqual(element, elementFromQueue);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_EmptyQueue_ThrowsException()
        {
            var queue = new LinkedQueue<int>();

            queue.Dequeue();

            // Assert: expect an exception
        }

        [TestMethod]
        public void EnqueueDequeue_1000Elements_ShouldWorkCorrectly()
        {
            const int NumberOfElements = 1000;
            var queue = new LinkedQueue<int>();

            for (int i = 0; i < NumberOfElements; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = 0; i < NumberOfElements; i++)
            {
                Assert.AreEqual(NumberOfElements - i, queue.Count);
                var element = queue.Dequeue();
                Assert.AreEqual(i, element);
                Assert.AreEqual(NumberOfElements - i - 1, queue.Count);
            }
        }

        [TestMethod]
        public void EnqueueDequeue_ManyChunks_ShouldWorkCorrectly()
        {
            var queue = new LinkedQueue<int>();
            const int Chunks = 1000;

            int value = 1;
            for (int i = 0; i < Chunks; i++)
            {
                Assert.AreEqual(0, queue.Count);
                var chunkSize = i + 1;
                for (int counter = 0; counter < chunkSize; counter++)
                {
                    Assert.AreEqual(value - 1, queue.Count);
                    queue.Enqueue(value);
                    Assert.AreEqual(value, queue.Count);
                    value++;
                }

                for (int counter = 0; counter < chunkSize; counter++)
                {
                    value--;
                    Assert.AreEqual(value, queue.Count);
                    queue.Dequeue();
                    Assert.AreEqual(value - 1, queue.Count);
                }

                Assert.AreEqual(0, queue.Count);
            }
        }

        [TestMethod]
        public void Enqueue500Elements_ToArray_ShouldWorkCorrectly()
        {
            var array = Enumerable.Range(1, 500).ToArray();
            var queue = new LinkedQueue<int>();

            foreach (int element in array)
            {
                queue.Enqueue(element);
            }

            var arrayFromQueue = queue.ToArray();

            CollectionAssert.AreEqual(array, arrayFromQueue);
        }

        [TestMethod]
        public void ToArray_EmptyStack_ShouldReturnEmptyArray()
        {
            var stack = new LinkedQueue<DateTime>();

            DateTime[] expected = new DateTime[0];
            var result = stack.ToArray();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
