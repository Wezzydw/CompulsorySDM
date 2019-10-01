using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewRatings;

namespace UnitTestRatings
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rating testRating = new Rating();
            int number = testRating.RatingTester(1);
            int expectedNumber = (4);
            Assert.Equals(number, expectedNumber);
            


        }
    }
}
