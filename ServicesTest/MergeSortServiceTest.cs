using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringSorter.Interfaces;
using StringSorter.Services;

namespace ServicesTest
{
    [TestClass]
    public class MergeSortServiceTest
    {
        private MergeSortService? service;

        [TestInitialize]
        public void SetUp()
        {
            this.service = new MergeSortService();
        }

        [TestMethod]
        public void Sort_ValidInput_SortsStringCorrectly()
        {
            service = new MergeSortService();
            string input = "befdac";
            string expected = "abcdef";

            string result = service.Sort(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Sort_ThrowsException_OnNullInput()
        {
            service = new MergeSortService();
            string? input = null;

            service.Sort(input);
        }
    }
}
