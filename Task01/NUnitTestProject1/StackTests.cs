using System;
using Task01;
using NUnit.Framework;


namespace Stack.Tests
{

	[TestFixture]
	public class StackTests
	{
		delegate int? D();
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
			//  int? actual=stack.Peek(0);
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
			int y = 5;
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
			//act
			stack.Peek();
			////assert

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
			D d=new D(stack.Pop);
			//act
			////assert
			//var x=Assert.Throws<IndexOutOfRangeException>(d);
		}
	}
}

