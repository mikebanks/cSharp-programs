using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTunes
{
    public partial class MainForm : Form
    {

        private BindingList<Song> SongList;
        public MainForm()
        {
            InitializeComponent();

            SongList = new BindingList<Song>();

            Song song1 = new Song();
            song1.SongName = "Star Spangled Banner";
            song1.ArtistName = "Franscis Scott Key";
            song1.AlbumName = "Unknown";
            song1.YearReleased = 1814;
            song1.DurationInSeconds = 133;
            song1.TrackNumber = 1;
            song1.TrackCount = 15;
            song1.Genre = "Contemporary";
            song1.MyRating = 5;

            SongList.Add(song1);

            listBox1.DataSource = SongList;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Song aSong = new Song();
            FormSong Songs = new FormSong(aSong);
            
            if (Songs.ShowDialog() == DialogResult.OK)
                SongList.Add(aSong);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem != null)
            {
                Song aSong = listBox1.SelectedItem as Song;
                FormSong Songs = new FormSong(aSong);
              
                Song song1 = new Song();
                song1.SongName = aSong.SongName;
                song1.ArtistName = aSong.ArtistName;
                song1.AlbumName = aSong.AlbumName;
                song1.YearReleased = aSong.YearReleased;
                song1.DurationInSeconds = aSong.DurationInSeconds;
                song1.TrackNumber = aSong.TrackNumber;
                song1.TrackCount = aSong.TrackCount;
                song1.Genre = aSong.Genre;
                song1.MyRating = aSong.MyRating;



                if (Songs.ShowDialog() == DialogResult.OK)
                {
                    //ListBox Refresh
                    SongList.Add(aSong);
                    SongList.Remove(aSong);
                }
                else
                {
                    aSong.SongName = song1.SongName;
                    aSong.ArtistName = song1.ArtistName;
                    aSong.AlbumName = song1.AlbumName;
                    aSong.YearReleased = song1.YearReleased;
                    aSong.DurationInSeconds = song1.DurationInSeconds;
                    aSong.TrackNumber = song1.TrackNumber;
                    aSong.TrackCount = song1.TrackCount;
                    aSong.Genre = song1.Genre;
                    aSong.MyRating = song1.MyRating;

                    aSong = this.listBox1.SelectedItem as Song;
                    SongList.Add(aSong);
                    SongList.Remove(aSong);
                }
            }
            else                
                MessageBox.Show("There are no seongs to edit...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure?", "Delete Song", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Song aSong = listBox1.SelectedItem as Song;
                    SongList.Remove(aSong);
                }
            }
            else
                MessageBox.Show("There are no seongs to delete...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
