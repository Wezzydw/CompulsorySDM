using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ReviewRatings
{
   public class FileReader
   {
       public static List<RatingEntity> _testData = new List<RatingEntity>();
       public FileReader()
        {/*
            _testData.Add(new RatingEntity()
                {Reviewer = 1, Grade = 3,Movie = 1});

            _testData.Add(new RatingEntity()
                { Reviewer = 2, Grade = 4, Movie = 1 });
            _testData.Add(new RatingEntity()
                { Reviewer = 3, Grade = 2, Movie = 1 });
            _testData.Add(new RatingEntity()
                { Reviewer = 1, Grade = 2, Movie = 3 });
            _testData.Add(new RatingEntity()
                { Reviewer = 5, Grade = 3, Movie = 2 });
            _testData.Add(new RatingEntity()
                { Reviewer = 4, Grade = 3, Movie = 7 });
            _testData.Add(new RatingEntity()
                { Reviewer = 3, Grade = 3, Movie = 2 });
            _testData.Add(new RatingEntity()
                { Reviewer = 4, Grade = 5, Movie = 2 });
            _testData.Add(new RatingEntity()
                { Reviewer = 2, Grade = 2, Movie = 4 });
            _testData.Add(new RatingEntity()
                { Reviewer = 6, Grade = 1, Movie = 8 });
            _testData.Add(new RatingEntity()
                { Reviewer = 1, Grade = 2, Movie = 6 });
            _testData.Add(new RatingEntity()
                { Reviewer = 4, Grade = 3, Movie = 5 });
            _testData.Add(new RatingEntity()
                { Reviewer = 2, Grade = 2, Movie = 1 });
            _testData.Add(new RatingEntity()
                { Reviewer = 1, Grade = 1, Movie = 5 });*/

            

        }

       public static void initdata()
        {
            string json = File.ReadAllText("C:\\Users\\Wezzy Laptop\\Desktop\\ratings.json");
            _testData = JsonConvert.DeserializeObject<List<RatingEntity>>(json);
        }
   }
}
