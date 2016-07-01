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
    public partial class Form1 : Form
    {
        private Song theSong;
        public Form1()
        {
            InitializeComponent();

            theSong = new Song();
            
            theSong.SongName = "Star Spangled Banner";
            theSong.ArtistName = "Franscis Scott Key";
            theSong.AlbumName = "Unknown";
            theSong.YearReleased = 1814;
            theSong.DurationInSeconds = 133;
            theSong.TrackNumber = 1;
            theSong.TrackCount = 1;
            theSong.Genre = "Contemporary";
            theSong.MyRating = 5;

            textBox_SongName.Text = theSong.SongName;
            textBox_ArtistName.Text = theSong.ArtistName;
            textBox_AlbumName.Text = theSong.AlbumName;
            textBox_YearReleased.Text = Convert.ToString(theSong.YearReleased);
            textBox_DurationInSeconds.Text = Convert.ToString(theSong.DurationInSeconds);
            textBox_TrackNumber.Text = Convert.ToString(theSong.TrackNumber);
            textBox_TrackCount.Text = Convert.ToString(theSong.TrackCount);
            textBox_Genre.Text = theSong.Genre;

            Text = theSong.GetTitle();

            switch (theSong.MyRating)
            {
                case 1:                   
                    radioButton_Rating1.Checked = true;                                                    
                    break;
                case 2:
                    radioButton_Rating2.Checked = true;
                    break;
                case 3:
                    radioButton_Rating3.Checked = true;
                    break;
                case 4:
                    radioButton_Rating4.Checked = true;
                    break;
                case 5:
                    radioButton_Rating5.Checked = true;
                    break;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_SongName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_SongName.Text.Length > 0 && textBox_SongName.Text.Length < 100)
                {
                    theSong.SongName = textBox_SongName.Text;
                    StatusLabel.Text = null;
                    textBox_SongName.BackColor = SystemColors.Window;
                }
                else
                    throw new System.ArgumentException();

                
            }
            catch
            {
                textBox_SongName.BackColor = Color.Pink;
                StatusLabel.Text = "Song Name is required and must be less than 100 Characters...";
            }
        }

        private void textBox_ArtistName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_ArtistName.Text.Length > 0 && textBox_ArtistName.Text.Length < 100)
                {
                    theSong.ArtistName = textBox_ArtistName.Text;
                    StatusLabel.Text = null;
                    textBox_ArtistName.BackColor = SystemColors.Window;
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                StatusLabel.Text = "Artist Name is required and must be less than 100 Characters...";
                textBox_ArtistName.BackColor = Color.Pink;
            }
        }

        private void textBox_AlbumName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_AlbumName.Text.Length > 0 && textBox_AlbumName.Text.Length < 100)
                {
                    theSong.AlbumName = textBox_AlbumName.Text;
                    textBox_AlbumName.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                StatusLabel.Text = "Album Name is required and must be less than 100 Characters...";
                textBox_AlbumName.BackColor = Color.Pink;
            }
        }

        private void textBox_YearReleased_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_YearReleased.Text.Length == 0)
                {                    
                    theSong.YearReleased = 0;
                    textBox_YearReleased.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else if (Convert.ToInt32(textBox_YearReleased.Text) >= 1500 && Convert.ToInt32(textBox_YearReleased.Text) <= DateTime.Now.Year)
                {
                    theSong.YearReleased = Convert.ToInt32(textBox_YearReleased.Text);
                    textBox_YearReleased.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else
                {
                    throw new System.ArgumentException();
                }                
            }
            catch
            {
                StatusLabel.Text = "Your Year is outside of the parameters of a valid year";
                textBox_YearReleased.BackColor = Color.Pink;
            }
        }

        private void textBox_DurationInSeconds_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_DurationInSeconds.Text.Length == 0)
                {
                    theSong.DurationInSeconds = 0;
                    textBox_DurationInSeconds.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else if (Convert.ToInt32(textBox_DurationInSeconds.Text) >= 10 && Convert.ToInt32(textBox_DurationInSeconds.Text) <= 1000)
                {
                    theSong.DurationInSeconds = Convert.ToInt32(textBox_DurationInSeconds.Text);
                    textBox_DurationInSeconds.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else
                {
                    throw new System.ArgumentException();
                }                
            }
            catch
            {
                StatusLabel.Text = "Your Duration is invalid...";
                textBox_DurationInSeconds.BackColor = Color.Pink;
            }
        }

        private void textBox_TrackNumber_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_TrackNumber.Text.Length == 0)
                {
                    theSong.TrackNumber = 0;
                    textBox_TrackNumber.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else if (Convert.ToInt32(textBox_TrackNumber.Text) >= 1 && Convert.ToInt32(textBox_TrackNumber.Text) <= 1000)
                {
                    theSong.TrackNumber = Convert.ToInt32(textBox_TrackNumber.Text);
                    textBox_TrackNumber.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                StatusLabel.Text = "Your Track Number is invalid...";
                textBox_TrackNumber.BackColor = Color.Pink;
            }
        }

        private void textBox_TrackCount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_TrackCount.Text.Length == 0)
                {
                    theSong.TrackCount = 0;
                    textBox_TrackCount.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else if (Convert.ToInt32(textBox_TrackCount.Text) >= 1 && Convert.ToInt32(textBox_TrackCount.Text) <= 1000)
                {
                    theSong.TrackCount = Convert.ToInt32(textBox_TrackCount.Text);
                    textBox_TrackCount.BackColor = SystemColors.Window;
                    StatusLabel.Text = null;
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                StatusLabel.Text = "Your Track Count is invalid...";
                textBox_TrackCount.BackColor = Color.Pink;
            }
        }

        private void textBox_Genre_Leave(object sender, EventArgs e)
        {
            try
            {
                theSong.Genre = textBox_Genre.Text;
                textBox_Genre.BackColor = SystemColors.Window;
            }
            catch
            {
                textBox_Genre.BackColor = Color.Pink;
            }
        }

        private void radioButton_Rating5_CheckedChanged(object sender, System.EventArgs e)
        {
            theSong.MyRating = 5;
        }

        private void radioButton_Rating4_CheckedChanged(object sender, System.EventArgs e)
        {
            theSong.MyRating = 4;
        }

        private void radioButton_Rating3_CheckedChanged(object sender, System.EventArgs e)
        {
            theSong.MyRating = 3;
        }

        private void radioButton_Rating2_CheckedChanged(object sender, System.EventArgs e)
        {
            theSong.MyRating = 2;
        }

        private void radioButton_Rating1_CheckedChanged(object sender, System.EventArgs e)
        {
            theSong.MyRating = 1;
        }

    }
}
