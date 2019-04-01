using System;
namespace Anghami
{
    public class Rating
    {
        private int _id { get; set; }
        private double _rating { get; set; }
        private Track _track { get; set; }
        private Account _user { get; set; }
        public Rating()
        {
        }
        
        public double CalculateRating (Track Track)
        {
            //TODO
            return 0;
        }
    }
}
