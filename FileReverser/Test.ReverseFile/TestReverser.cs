using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseFile;

namespace Test.ReverseFile
{
    [TestClass]
    public class TestReverser
    {
        [TestMethod]
        public void TestStringReverse()
        {
            var input = "Test this.";
            var expectedOutput = ".siht tseT";

            var reverse = new Reverser();
            var output = reverse.ReverseLine(input);
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestLineOrderReverse()
        {
            var path = @"c:\temp\test.txt";
            var expectedOutput = File.ReadAllLines(path);

            var reverse = new Reverser();
            var output = reverse.ReverseLineOrder(path);
            Assert.AreEqual(expectedOutput[0], output[2]);
        }
    }
}
