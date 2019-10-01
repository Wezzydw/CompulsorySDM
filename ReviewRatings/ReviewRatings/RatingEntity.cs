using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewRatings
{
    public class RatingEntity
    {
        public  int Reviewer { get; set; }
        public int Grade { get; set; }

        public DateTime Date { get; set; }
        
        public  int Movie { get; set; }
    }
}
