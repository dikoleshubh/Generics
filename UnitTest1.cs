using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest
    {  // Check Maximum String And Return NIFTY
        [TestMethod]
        public void CheckFirstString()
        {
            string max = "NIFTY";
            string Result = MaxNumbers.StringMaximumNumber("NIFTY", "NASDAQ", "SENSEX");
            Assert.AreEqual(max, Result);
        }

        /// <summary>
         // Check Maximum String And Return  NASDAQ
        /// </summary>
        [TestMethod]
        public void CheckSecondString()
        {
            string max = "NASDAQ";
            string Result = MaxNumbers.StringMaximumNumber("NIFTY", "NASDAQ", "SENSEX");
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check Maximum String And Return  SENSEX
        /// </summary>
        [TestMethod]
        public void CheckThirdString()
        {
            string max = "SENSEX";
            string Result = MaxNumbers.StringMaximumNumber("NIFTY", "NASDAQ", "SENSEX");
            Assert.AreEqual(max, Result);
        }
    }

    
}
