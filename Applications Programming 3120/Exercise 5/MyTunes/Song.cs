using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyTunes
{
    public class Song
    {
        public Song() { }
        
        private string _SongName;
        public string SongName
        {
            get
            {
                return _SongName;
            }
            set
            {
                if (value.Length > 0 && value.Length < 100)
                {
                    _SongName = value;
                }
                else
                {
                    throw new Exception("The Song Name is too long");
                }
            }
        }

        private string _ArtistName;
        public string ArtistName
        {
            get
            {
                return _ArtistName;
            }
            set
            {
                if (value.Length > 0 && value.Length < 100)
                {
                    _ArtistName = value;
                }
                else
                {
                    throw new Exception("Invalid Artist Name Parameter");
                }
            }
        }

        private string _AlbumName;
        public string AlbumName 
        {
            get
            {
                return _AlbumName;    
            }
            set
            {
                if (value.Length > 0 && value.Length < 100)
                {
                    _AlbumName = value;
                }
                else
                {
                    throw new Exception("Invalid Album Name Parameter");
                }
            }
        }

        private int _YearReleased;
        public int YearReleased
        {
            get
            {
                return _YearReleased;
            }
            set
            {
                if (value > 1500 && value <= DateTime.Now.Year)
                {
                    Convert.ToInt32(value);
                    _YearReleased = value;
                }
                else
                {
                    throw new Exception("Invalid Year Released Parameter");
                }
            }
        }

        private int _DurationInSeconds;
        public int DurationInSeconds
        {
            get
            {
                return _DurationInSeconds;
            }
            set
            {
                if (value == 0)
                {
                    _DurationInSeconds = 0;
                }
                else if (value > 10 && value < 1000)
                {
                    _DurationInSeconds = value;
                }
                else
                {
                    throw new Exception("Invalid Duration Parameter");
                }
            }
        }

        private int _TrackNumber;
        public int TrackNumber
        {
            get
            {
                return _TrackNumber;
            }
            set
            {
                if (value == 0)
                {
                    _TrackNumber = 0;
                }                
                else if (_TrackCount == 0)
                {
                    _TrackNumber = value; 
                }
                else if (_TrackCount != 0)
                {        
                    if (value <= _TrackCount)
                        _TrackNumber = value;
                    else                        
                        throw new Exception("Invalid Track Parameter. Out of Range!");                           
                }
                else
                {
                    throw new Exception("Invalid Track Number Parameter");
                }
            }
        }

        private int _TrackCount;
        public int TrackCount
        {
            get
            {
                return _TrackCount;
            }
            set
            {
                if (value == 0)
                {
                    _TrackCount = 0;
                }
                
                else if (_TrackNumber == 0)
                {
                    _TrackCount = value;
                }
                else if (_TrackNumber != 0)
                {
                    if (value >= _TrackNumber)
                        _TrackCount = value;
                    else
                        throw new Exception("Invalid Track Parameter. Out of Range!");
                }
                else
                {
                    throw new Exception("Invalid Track Number Parameter");
                }
            }
        }

        private string _Genre;
        public string Genre
        {
            get
            {
                return _Genre;
            }
            set
            {
                _Genre = value;
            }
        }

        private int _MyRating;
        
        public int MyRating
        {
            get
            {
                return _MyRating;
            }
            set
            {              
            if (value > 0 && value <= 5)
                {               
                    _MyRating = value;
                }
            }
        }

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

        public override string ToString()
        {
            return GetTitle();
        }

        private const char _delimiter = '\t';

        public string ToFileString()
        {
            // Start with an empty string
            string fileString = "";

            // Add each 
            fileString += this._SongName + _delimiter;
            fileString += this._ArtistName + _delimiter;
            fileString += this._AlbumName + _delimiter;
            fileString += this._YearReleased.ToString() + _delimiter;
            fileString += this._DurationInSeconds.ToString() + _delimiter;
            fileString += this._TrackNumber.ToString() + _delimiter;
            fileString += this._TrackCount.ToString() + _delimiter;
            fileString += this._Genre + _delimiter;
            fileString += this._MyRating.ToString();

            return fileString;
        }

        public Song(string FileString)
        {
            String[] FileSection = FileString.Split(_delimiter);

            if (FileSection.Length != 9)
            {
                throw new Exception("Does not have all sections. Song is invalid!");
            }
            try
            {
                this._SongName = FileSection[0];
                this._ArtistName = FileSection[1];
                this._AlbumName = FileSection[2];
                this._YearReleased = Convert.ToInt32(FileSection[3]);
                this._DurationInSeconds = Convert.ToInt32(FileSection[4]);
                this._TrackNumber = Convert.ToInt32(FileSection[5]);
                this._TrackCount = Convert.ToInt32(FileSection[6]);
                this._Genre = FileSection[7];
                this._MyRating = Convert.ToInt32(FileSection[8]);
            }
            catch (Exception ex)
            {
                throw new Exception("A parameter is invalid!", ex);
            }
        }
    }
}
