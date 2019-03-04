using System;
using Task01;
using NUnit.Framework;


namespace Stack.Tests
{

    [TestFixture]
    public class StackTests
    {
        TestDelegate D;
        Task01.Stack<int?> stack;
        [SetUp]
        public void TestInitialize()
        {

            stack = new Task01.Stack<int?>();

        }
        [Test]
        public void Push_FirstElementToEmptyArray_Pushed()
        {
            //arrange
            int x = 3;
            //act
            stack.Push(x);
            ////assert
            Assert.AreEqual(x, stack.Peek());
        }
        [Test]
        public void Push_ElementToNotEmptyStack_Pushed()
        {
            //arrange
            int x = 3;
            int y = 5;
            //act
            stack.Push(x);
            stack.Push(y);
            ////assert
            Assert.AreEqual(y, stack.Peek());
        }
        [Test]
        public void Peek_ELementFromNotEmptyStack_Peeked()
        {
            //arrange
            int x = 3;
            int? y = 5;
            //act
            stack.Push(x);
            stack.Push(y);
            ////assert
            Assert.AreEqual(y, stack.Peek());
        }
        [Test]
        public void Peek_First_ELementFromEmptyStack_Exception()
        {
            //arrange
            D = new TestDelegate(() => stack.Pop());
            //act
            ////assert
            Assert.Throws<IndexOutOfRangeException>(D, "Negative index");
        }
        [Test]
        public void Pop_ELementFromNotEmptyStack_Poped()
        {
            //arrange
            int x = 3;
            int y = 5;
            //act
            stack.Push(x);
            stack.Push(y);
            ////assert
            Assert.AreEqual(y, stack.Pop());
        }

        [Test]
        public void Pop_First_ELementFromEmptyStack_Exception()
        {
            //arrange
            D = new TestDelegate(() => stack.Pop());
            //act
            ////assert
            Assert.Throws<IndexOutOfRangeException>(D, "Negative index");
        }
    }
}


