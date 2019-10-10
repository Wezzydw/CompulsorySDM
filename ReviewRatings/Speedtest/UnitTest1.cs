using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewRatings;

namespace Speedtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void init()
        {
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
            Console.WriteLine(s.ElapsedMilliseconds/1000.0);
           Assert.IsTrue(s.ElapsedMilliseconds/1000.0 < 1.0);

        }
    }
}
