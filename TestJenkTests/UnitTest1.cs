using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestJenkCons;
namespace TestJenkTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SayItShouldReturnHello()
        {
            var expected = "Hello";

            var sut = new Program();
            var actual = sut.SayIt();
            Assert.AreEqual(expected, actual);
        }
    }
}
