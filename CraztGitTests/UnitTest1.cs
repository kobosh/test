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
            string  actual = sut.SayIt();
            Assert.AreEqual(expected, actual);
            
        }
    }
}
