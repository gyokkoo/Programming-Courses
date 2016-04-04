namespace _05.LinkedStack.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestsLinkedStack
    {
        [TestMethod]
        public void Count_EmptyStack_ShouldBeZero()
        {
            var stack = new LinkedStack<int>();

            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Push_OneElement_ShouldIncrementCount()
        {
            var stack = new LinkedStack<int>();

            stack.Push(1000);

            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void Pop_OneRandomElement_ShouldBeTheSameAsPushedElement()
        {
            var stack = new LinkedStack<int>();
            var randomNumber = new Random().Next();

            stack.Push(randomNumber);
            var removedNumber = stack.Pop();

            Assert.AreEqual(randomNumber, removedNumber);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void PushPop_1000Elements_ShouldWorkCorrectly()
        {
            const int N = 1000;
            var stack = new LinkedStack<string>();

            Assert.AreEqual(0, stack.Count);
            for (int i = 0; i < N; i++)
            {
                stack.Push(i.ToString());
                Assert.AreEqual(i, stack.Count - 1);
            }

            for (int i = N - 1; i >= 0; i--)
            {
                var removedItem = stack.Pop();
                Assert.AreEqual(removedItem, i.ToString());
                Assert.AreEqual(i, stack.Count);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_EmptyStack_ShouldThrow()
        {
            var stack = new LinkedStack<int>();

            stack.Pop();
        }

        [TestMethod]
        public void PushPop_TwoElements_ShouldWorkCorrectly()
        {
            var stack = new LinkedStack<int>();
            var randomElementOne = new Random().Next();
            var randomElementTwo = new Random().Next() + 1;

            Assert.AreEqual(0, stack.Count);

            stack.Push(randomElementOne);
            Assert.AreEqual(1, stack.Count);

            stack.Push(randomElementTwo);
            Assert.AreEqual(2, stack.Count);

            var firstRemovedElement = stack.Pop();
            var secondRemovedElement = stack.Pop();
            Assert.AreEqual(randomElementTwo, firstRemovedElement);
            Assert.AreEqual(randomElementOne, secondRemovedElement);

            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void ToArray_SeveralElements_ShouldReturnInReversedOrder()
        {
            var stack = new LinkedStack<int>();
            stack.Push(3);
            stack.Push(5);
            stack.Push(-2);
            stack.Push(7);

            var expected = new[] { 7, -2, 5, 3 };
            var result = stack.ToArray();

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToArray_EmptyStack_ShouldReturnEmptyArray()
        {
            var stack = new LinkedStack<DateTime>();

            DateTime[] expected = new DateTime[0];
            var result = stack.ToArray();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
