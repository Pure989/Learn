using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnClassLibrary.Tests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_TimeInSecunds()
        {
            //arrange
            int a = 2;
            int b = 3;
            int expected = 7380;
            //act
            LearnClass c = new LearnClass();
            int actual = c.TimeInSecunds(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SecondsInHours()
        {
            //arrange
            int a = 7380;
            int expected = 2;
            //act
            LearnClass c = new LearnClass();
            int actual = c.SecondsInHours(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SecondsInMinute()
        {
            //arrange
            int a = 7380;
            int expected = 0;
            //act
            LearnClass c = new LearnClass();
            int actual = c.SecondsInMinute(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
