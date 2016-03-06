using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace UnitTestForStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_NewStack_ReturnTrue()
        {
            MyStack<string> stack = new MyStack<string>();

            bool expected = true;
            bool actual = stack.isEmpty();

            Assert.AreEqual(expected, actual, "IsEmputy fail on new created stack");
        }

        [TestMethod]
        public void IsEmpty_UsedToHaveItemStack_Returntrue()
        {
            MyStack<string> stack = new MyStack<string>();

            bool expected = true;
            stack.Push("aaa");
            stack.Push("bbb");
            stack.Pop();
            stack.Pop();
            bool actual = stack.isEmpty();

            Assert.AreEqual(expected, actual, "IsEmputy fail on use to have item stack");
        }

        [TestMethod]
        public void IsEmpty_HaveItem_ReturnFalse()
        {
            MyStack<string> stack = new MyStack<string>();

            bool expected = false;
            stack.Push("aaa");
            bool actual = stack.isEmpty();

            Assert.AreEqual(expected, actual, "IsEmputy fail on have item stack");
        }

        [TestMethod]
        public void Count_EmptyStack_ReturnZero()
        {
            MyStack<string> stack = new MyStack<string>();

            int expected = 0;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual, "Count fail empty stack");
        }

        [TestMethod]
        public void Count_UseToHaveItem_ReturnZero()
        {
            MyStack<string> stack = new MyStack<string>();

            int expected = 0;
            stack.Push("aaa");
            stack.Push("bbb");
            stack.Pop();
            stack.Pop();
            int actual = stack.Count();

            Assert.AreEqual(expected, actual, "Count fail on use to have item stack");
        }

        [TestMethod]
        public void Count_HaveItem_ReturnItemCount()
        {
            MyStack<string> stack = new MyStack<string>();
            Random rand = new Random();

            int expected = rand.Next(1, 10000);
            for (int i = 0; i < expected; i++)
            {
                stack.Push("aaa");
            }
            int actual = stack.Count();

            Assert.AreEqual(expected, actual, "Count fail on have item stack");
        }

        [TestMethod]
        public void Peek_HaveItem_ReturnLastOne()
        {
            MyStack<string> stack = new MyStack<string>();

            stack.Push("aaa");
            stack.Push("bbb");
            stack.Push("ccc");

            string expected = "ccc";
            string actual = stack.Peek();

            Assert.AreEqual(expected, actual, "Peek fail on have item stack");
        }

        [TestMethod]
        public void Peek_HaveItem_NotDeleteLastItem()
        {
            MyStack<string> stack = new MyStack<string>();

            stack.Push("aaa");
            stack.Push("bbb");
            stack.Push("ccc");

            stack.Peek();

            string expected = "ccc";
            string actual = stack.Peek();

            Assert.AreEqual(expected, actual, "Peek fail on have item stack");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Peek_Empty_Crash()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Peek();
        }

        [TestMethod]
        public void Pop_HaveItem_ReturnLastItem()
        {
            MyStack<string> stack = new MyStack<string>();

            stack.Push("aaa");
            stack.Push("bbb");
            stack.Push("ccc");

            string expected = "ccc";
            string actual = stack.Pop();

            Assert.AreEqual(expected, actual, "Pop fail on have item stack");
        }

        [TestMethod]
        public void Pop_HaveItem_RemoveLastOne()
        {
            MyStack<string> stack = new MyStack<string>();

            stack.Push("aaa");
            stack.Push("bbb");
            stack.Push("ccc");

            stack.Pop();

            string expected = "bbb";
            string actual = stack.Peek();

            Assert.AreEqual(expected, actual, "Pop fail on have item stack");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Pop_EmptyStack_Crash()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Pop();
        }

        [TestMethod]
        public void Count_AfterPeek_NothingChange()
        {
            MyStack<string> stack = new MyStack<string>();

            stack.Push("aaa");
            stack.Push("bbb");
            stack.Push("ccc");

            stack.Peek();

            int expected = 3;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual, "Count fail on after peek stack");
        }

        [TestMethod]
        public void Count_AfterPop_LessOne()
        {
            MyStack<string> stack = new MyStack<string>();

            stack.Push("aaa");
            stack.Push("bbb");
            stack.Push("ccc");

            stack.Pop();

            int expected = 2;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual, "Count fail on after pop stack");
        }
    }
}
