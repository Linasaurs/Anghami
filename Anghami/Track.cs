using System;
using System.Collections.Generic;

namespace Anghami
{
    public class Track
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private Album _album { get; set; }
        private List<Artist> _artist { get; set; }
        private Genre _genre { get; set; }
        private string _lyrics { get; set; }
        private double _rating { get; set; }
        private MediaType _mediatype { get; set; }
        public Track()
        {
        }

        public void PlayTrack (Track RequestedTrack)
        {
            //TODO
        }

        public List<Track> FilterMusicByGenre(Genre GenreName)
        {
            //TODO
            return new List<Track>();
        }

        public List<Track> SearchInTrack<T> (T SearchFilter)
        {
            //TODO
            return new List<Track>();
        }
    }
}
