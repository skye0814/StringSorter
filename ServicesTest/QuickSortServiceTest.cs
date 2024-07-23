using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringSorter.Services;

namespace ServicesTest
{
    [TestClass]
    public class QuickSortServiceTest
    {
        private QuickSortService? service;

        [TestInitialize]
        public void SetUp()
        {
            this.service = new QuickSortService();
        }

        [TestMethod]
        public void Sort_ValidInput_SortsStringCorrectly()
        {
            service = new QuickSortService();
            string input = "befdac";
            string expected = "abcdef";

            string result = service.Sort(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Sort_ThrowsException_OnNullInput()
        {
            service = new QuickSortService();
            string? input = null;

            service.Sort(input);
        }
    }
}
