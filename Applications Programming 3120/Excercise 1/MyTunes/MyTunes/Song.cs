using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTunes
{
    class Song
    {
        public string SongName { get; set; }

        public string ArtistName { get; set; }

        public string AlbumName { get; set; }

        public int YearReleased { get; set; }

        public int DurationInSeconds { get; set; }

        public int TrackNumber { get; set; }

        public int TrackCount { get; set; }

        public string Genre { get; set; }

        public int MyRating { get; set; }

        public String GetTitle()
        {
            String Title = " ";
            
            if (TrackNumber == 0)
            {
                Title =  SongName + " by " + ArtistName;
            }
            else
            {
                Title = TrackNumber + " - " + SongName + " by " + ArtistName;
            }

            return Title;
        }
    }
}
