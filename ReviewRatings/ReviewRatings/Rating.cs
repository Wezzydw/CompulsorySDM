using System;
using System.Collections.Generic;
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


        public int NumberOfReviews(int id)
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

            return rating / counter;
        }
    }
    
}
