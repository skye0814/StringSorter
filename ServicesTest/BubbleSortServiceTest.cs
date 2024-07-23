using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringSorter.Interfaces;
using StringSorter.Services;

namespace ServicesTest
{
    [TestClass]
    public class BubbleSortServiceTest
    {
        private BubbleSortService? service;

        [TestInitialize]
        public void SetUp()
        {
            this.service = new BubbleSortService();
        }

        [TestMethod]
        public void Sort_ValidInput_SortsStringCorrectly()
        {
            service = new BubbleSortService();
            string input = "befdac";
            string expected = "abcdef";

            string result = service.Sort(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Sort_ThrowsException_OnNullInput()
        {
            service = new BubbleSortService();
            string? input = null;

            service.Sort(input);
        }
    }
}