using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewRatings;

namespace UnitTestRatings
{
    [TestClass]
    public class UnitTest1
    {

        private static TestContext test1;
        [ClassInitialize]
        public static void init(TestContext test)
        {
            test1 = test;
            FileReader.initdata();
        }

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
            double result = rating.NumberOfReviews(1);
            double expectedResult = 2;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Task2AverageRateFromReviewerExeption()
        {
            Rating testRating = new Rating();
            int number = testRating.RatingTester(-1);
        }

        [TestMethod]
        public void CountRatingsFromReviewer()
        {
            Rating testRating = new Rating();
            int number = testRating.CountOfGradesFromReviewer(1,2);
            int expectedResult = 2;
            Assert.AreEqual(number, expectedResult);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CountRatingsFromReviewerException()
        {
            Rating testRating = new Rating();
            int number = testRating.CountOfGradesFromReviewer(17,6);

        }
        [TestMethod]
        public void CountMovieReview()
        {
            Rating testRating = new Rating();
            int number = testRating.CountMovieReview(1);
            int expectedResult = 4;
            Assert.AreEqual(number, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CountMovieReviewException()
        {
            Rating testRating = new Rating();
            int number = testRating.CountMovieReview(0);

        }

        [TestMethod]
        public void AverageMovieRatiing()
        {
            Rating testRating = new Rating();
            double number = testRating.AverageMovieRating(1);
            double expectedResult = 11.0 / 4.0;
            Assert.AreEqual(expectedResult, number);
            
        }

    }
}

