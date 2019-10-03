using System;
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
            Assert.AreEqual(number, expectedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod2()
        {
            Rating testRating = new Rating();
            int number = testRating.RatingTester(-1);
        }

        [TestMethod]
        public void Task2AverageRateFromReviewer()
        {
            Rating rating = new Rating();
            int result = rating.NumberOfReviews(1);
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, result);
        }

    }
}
