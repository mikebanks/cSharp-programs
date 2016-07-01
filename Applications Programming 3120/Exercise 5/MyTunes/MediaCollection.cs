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

        public MediaCollection ()
        {
            MediaList = new BindingList<Song>();
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
    }
}
