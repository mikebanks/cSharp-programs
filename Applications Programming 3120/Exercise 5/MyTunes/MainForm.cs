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
        private MediaCollection _MediaCollection;
        
        
        public MainForm()
        {
            InitializeComponent();

            _MediaCollection = new MediaCollection();
            listBox1.DataSource = _MediaCollection.MediaList;

            if (_MediaCollection.MediaList.Count == 0)
            {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Song aSong = new Song();
            FormSong Songs = new FormSong(aSong);
            
            if (Songs.ShowDialog() == DialogResult.OK)
                _MediaCollection.MediaList.Add(aSong);
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
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
                    _MediaCollection.MediaList.Add(aSong);
                    _MediaCollection.MediaList.Remove(aSong);
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
                    _MediaCollection.MediaList.Add(aSong);
                    _MediaCollection.MediaList.Remove(aSong);
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
                    _MediaCollection.MediaList.Remove(aSong);

                    if (_MediaCollection.MediaList.Count == 0)
                    {
                        buttonEdit.Enabled = false;
                        buttonDelete.Enabled = false;
                    }
                }
            }
            else
                MessageBox.Show("There are no seongs to delete...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogue = new OpenFileDialog();
            Dialogue.Filter = "Text Files|*.txt";
            if (Dialogue.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _MediaCollection.Load(Dialogue.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (_MediaCollection.MediaList.Count == 0)
                {
                    buttonEdit.Enabled = false;
                    buttonDelete.Enabled = false;
                }
                else
                {
                    buttonEdit.Enabled = true;
                    buttonDelete.Enabled = true;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dialogue = new SaveFileDialog();
            Dialogue.Filter = "Text Files|*.txt";
            if (Dialogue.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _MediaCollection.Save(Dialogue.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
