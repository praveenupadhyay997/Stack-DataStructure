// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueUnitTest.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UnitTestProject
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StackAndQueueImplementation;
    [TestClass]
    public class QueueUnitTest
    {
        [TestMethod]
        [TestCategory("Testing for Stack")]
        public void TestMethodForStack()
        {
            //Arrange
            Stack stack = new Stack();
            //Act
            stack.Push(70);
            int expected = 70;
            int actual = stack.Peek();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Testing for Queue")]
        public void TestMethodForQueue()
        {
            //Arrange
            Queue queue = new Queue();
            //Act
            queue.Enqueue(56);
            int expected = 56;
            int actual = queue.Dequeue();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
