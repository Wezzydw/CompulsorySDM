using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ReviewRatings
{
    public class Rating
    {
        private FileReader fileReader = new FileReader();

        public int RatingTester(int id)
        {
            if (id <= 0)
            {
                throw new Exception();
            }
            int counter = 0;
            for (int i = 0; i < fileReader._testData.Count; i++)
            {
                if (fileReader._testData[i].Reviewer.Equals(id))
                {
                    counter++;
                }
            }

            return counter;
        }


        public double NumberOfReviews(int id)
        {
            int counter = 0;
            int rating = 0;
            foreach (RatingEntity data in fileReader._testData)
            {
                if (data.Reviewer.Equals(id))
                {
                    counter++;
                    rating += data.Grade;
                }
            }
            if (id <= 0 || counter == 0)
            {
                throw new Exception();
            }
            return rating / counter;
        }

        public int CountOfGradesFromReviewer(int id, int grade)
        {
            if (id <= 0 || grade <1 || grade > 5) 
            {
                throw new Exception();
            }
            int counter = 0;
            foreach (RatingEntity data in fileReader._testData)
            {
                if (data.Reviewer.Equals(id) && data.Grade.Equals(grade))
                {
                    counter++;
                }
            }

            return counter;
        }

        public int CountMovieReview(int id)
        {
            if (id <= 0)
            {
                throw new Exception();
            }
            int counter = 0;
            foreach (RatingEntity data in fileReader._testData)
            {
                if (data.Movie.Equals(id))
                counter++;
            }

            return counter;
        }

        public double AverageMovieRating(int movie)
        {
            int counter = 0;
            int rating = 0;
            foreach (RatingEntity data in fileReader._testData)
            {
                if (data.Movie.Equals(movie))
                {
                    counter++;
                    rating += data.Grade;
                }
            }
            return (double)rating/(double)counter;
        }
    }
    
}
