using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTunes
{
    class MediaCollection
    {
        public BindingList<Song> MediaList { get; private set; }
        public BindingList<Song> FilteredMediaList { get; private set; }

        public MediaCollection ()
        {
            MediaList = new BindingList<Song>();
            FilteredMediaList = new BindingList<Song>();
        }

        public void Load(string filePath)
        {
            MediaList.Clear();
            using (StreamReader Stream1 = new StreamReader(filePath))
            {
                try
                {
                    while (Stream1.EndOfStream != true)
                    {
                        string line = Stream1.ReadLine();
                        if (String.IsNullOrEmpty(line) == false)
                        {
                            Song S = new Song(line);
                            MediaList.Add(S);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error Opening File", ex);
                }
            }
        }

        public void Save(string filePath)
        {
            using (StreamWriter Write1 = new StreamWriter(filePath, false))
            {
                try
                {
                    foreach (Song S in MediaList)
                    {
                        Write1.WriteLine(S.ToFileString());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error Saving file", ex);
                }
            }
        }

        public void FilterBy(SongFilter filter)
        {
            FilteredMediaList.Clear();
            foreach (Song s in MediaList)
            {
                FilteredMediaList.Add(s);
            }

            for (int i = 0; i < FilteredMediaList.Count; i++)
            {
                Song s = FilteredMediaList[i];

                int minYear;
                int maxYear;
                int minRating;
                int maxRating;

                if (s.SongName.Contains(filter.SongName))
                {
                    FilteredMediaList.Remove(s);
                    i--;
                    continue;
                }

                bool shouldFilter = int.TryParse(filter.MinYear, out minYear);
                if (shouldFilter == true && s.YearReleased < minYear)
                {
                    FilteredMediaList.Remove(s);
                    i--;
                    continue;
                }

                shouldFilter = int.TryParse(filter.MaxYear, out maxYear);
                if (shouldFilter == true && s.YearReleased > maxYear)
                {
                    FilteredMediaList.Remove(s);
                    i--;
                    continue;
                }

                shouldFilter = int.TryParse(filter.MinRating, out minRating);
                if (shouldFilter == true && s.MyRating < minRating)
                {
                    FilteredMediaList.Remove(s);
                    i--;
                    continue;
                }

                shouldFilter = int.TryParse(filter.MaxRating, out maxRating);
                if (shouldFilter == true && s.MyRating > maxRating)
                {
                    FilteredMediaList.Remove(s);
                    i--;
                    continue;
                }
            }
        }
    }
}
