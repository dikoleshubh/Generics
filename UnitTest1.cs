using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest
    { 
        //Ensure the test data has Max Number in the First position

        [TestMethod]
        [DataRow(64, 53, 32)]
        public void Value(int firstValue, int secondValue, int thirdValue)
        {

            int expectedResult = firstValue;
            int result = MaxNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        //Ensure the test data has Max Number in the Second position

        [TestMethod]
        [DataRow(43, 443, 32)]
        public void Value(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = secondValue;
            int result = MaxNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }


        //Ensure the test data has Max Number in the Third position
        [DataRow(33, 53, 93)]
        public void Value(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = thirdValue;
            int result = MaxNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

    }
}
