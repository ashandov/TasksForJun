using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task01;

namespace StackTests
{
    [TestClass]
    public class StackTests
    {
            [TestMethod]
            public void Push_3ToEmptyArray() 
        {
          //arrange
            int x=3;
          //act
            var stack = new Stack();
            stack.Push(x);
          //  int? actual=stack.Peek(0);
          ////assert
          //  Assert.AreEqual(x,stack.Peek(0));
        }
            [TestMethod]
            public void Push_4ToNotEmptyArray() { }
        }
    }

