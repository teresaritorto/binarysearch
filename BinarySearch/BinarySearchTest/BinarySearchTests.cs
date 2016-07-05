using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearch;

namespace BinarySearchTest
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void TestCorrectSearchIndex()
        {
            var testArray = new int[] { 1, 4, 7, 22, 28, 33 };
            var searchItem = 28;
            var result = testArray.BinarySearch(searchItem);

            Assert.IsTrue(result == 4);
        }

        [TestMethod]
        public void TestNotFoundEntryReturnsCorrectly()
        {
            var testArray = new int[] { 1, 4, 7, 22, 28, 33 };
            var searchItem = 100;
            var result = testArray.BinarySearch(searchItem);

            Assert.IsTrue(result == -1);
        }       
    }
}
