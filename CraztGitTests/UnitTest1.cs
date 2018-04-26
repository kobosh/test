using CrazyGit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            int expected = 100;
            var sut = new Program();
            int actual = sut.Add(50, 50);
            Assert.AreEqual(expected, actual);

        }
    }
}
