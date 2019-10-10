using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewRatings;

namespace Speedtest
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
            Stopwatch s = new Stopwatch();
            s.Start();
            double number = testRating.AverageMovieRating(1);
            s.Stop();
            Assert.IsTrue(s.ElapsedMilliseconds/1000.0 < 1.0);

        }
        [TestMethod]
        public void TestMethod2()
        {

            Rating testRating = new Rating();
            Stopwatch s = new Stopwatch();
            s.Start();
            testRating.NumberOfReviews(1);
            s.Stop();
            Assert.IsTrue(s.ElapsedMilliseconds / 1000.0 < 1.0);

        }
        [TestMethod]
        public void TestMethod3()
        {

            Rating testRating = new Rating();
            Stopwatch s = new Stopwatch();
            s.Start();
            testRating.CountOfGradesFromReviewer(1, 2);
            s.Stop();
            Assert.IsTrue(s.ElapsedMilliseconds / 1000.0 < 1.0);

        }
        [TestMethod]
        public void TestMethod4()
        {

            Rating testRating = new Rating();
            Stopwatch s = new Stopwatch();
            s.Start();
            testRating.CountMovieReview(1);
            s.Stop();
            Assert.IsTrue(s.ElapsedMilliseconds / 1000.0 < 1.0);

        }
        [TestMethod]
        public void TestMethod5()
        {

            Rating testRating = new Rating();
            Stopwatch s = new Stopwatch();
            s.Start();
            testRating.AverageMovieRating(1);
            s.Stop();
            Assert.IsTrue(s.ElapsedMilliseconds / 1000.0 < 1.0);

        }
    }
}
