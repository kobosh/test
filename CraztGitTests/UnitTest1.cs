using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrazyGit;
namespace CraztGitTests
{
    [TestClass]
    public class CrazyGitTests
    {
        [TestMethod]
        public void SayItShouldReturnHello()
        {
            string expected = "hello";
            var sut = new Program();
            string actual = sut.SayIt();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddShouldReturnTen()
        {
            int expected = 10;
            var sut = new Program();
            int actual = sut.Add(5, 5);
            Assert.AreEqual(expected, actual);

        }
    }
}
