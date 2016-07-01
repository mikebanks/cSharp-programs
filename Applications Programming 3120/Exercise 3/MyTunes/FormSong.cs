using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyTunes
{
    public partial class FormSong : Form
    {
        private Song theSong;

        public Song TheSong
        {
            get { return theSong; }
            set { theSong = value; }
        }

        public FormSong(Song aSong)
        {
            InitializeComponent();

            theSong = aSong;

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
            this.DialogResult = DialogResult.Cancel;
            //Close();
        }

        private bool IsValid()
        {
            bool valid = true;
            try
            {
                theSong.SongName = textBox_SongName.Text;
                theSong.ArtistName = textBox_ArtistName.Text;
                theSong.AlbumName = textBox_AlbumName.Text;
                if (textBox_YearReleased.Text.Length == 0)
                {
                    theSong.YearReleased = 0;
                    Error4.SetError(textBox_YearReleased, "");
                }
                else if (Convert.ToInt32(textBox_YearReleased.Text) >= 1500 && Convert.ToInt32(textBox_YearReleased.Text) <= DateTime.Now.Year)
                {
                    theSong.YearReleased = Convert.ToInt32(textBox_YearReleased.Text);
                    Error4.SetError(textBox_YearReleased, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }

                if (textBox_DurationInSeconds.Text.Length == 0)
                {
                    theSong.DurationInSeconds = 0;
                    Error5.SetError(textBox_DurationInSeconds, "");
                }
                else if (Convert.ToInt32(textBox_DurationInSeconds.Text) >= 10 && Convert.ToInt32(textBox_DurationInSeconds.Text) <= 1000)
                {
                    theSong.DurationInSeconds = Convert.ToInt32(textBox_DurationInSeconds.Text);
                    Error5.SetError(textBox_DurationInSeconds, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }

                if (textBox_TrackNumber.Text.Length == 0)
                {
                    theSong.TrackNumber = 0;
                    Error6.SetError(textBox_TrackNumber, "");
                }
                else if (Convert.ToInt32(textBox_TrackNumber.Text) == 0)
                {
                    theSong.TrackNumber = 0;
                    Error6.SetError(textBox_TrackNumber, "");
                }
                else if (Convert.ToInt32(textBox_TrackNumber.Text) >= 1 && Convert.ToInt32(textBox_TrackNumber.Text) <= Convert.ToInt32(textBox_TrackCount.Text))
                {
                    theSong.TrackNumber = Convert.ToInt32(textBox_TrackNumber.Text);
                    Error6.SetError(textBox_TrackNumber, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }

                if (textBox_TrackCount.Text.Length == 0)
                {
                    theSong.TrackCount = 0;
                    Error7.SetError(textBox_TrackCount, "");
                }
                else if (Convert.ToInt32(textBox_TrackCount.Text) >= 1 && Convert.ToInt32(textBox_TrackCount.Text) <= 1000)
                {
                    theSong.TrackCount = Convert.ToInt32(textBox_TrackCount.Text);
                    Error7.SetError(textBox_TrackCount, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
        
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Can't save an invalid song.");
            }
            //Close();
        }

        private void textBox_SongName_Leave(object sender, EventArgs e)
        {
            
            try
            {
                if (textBox_SongName.Text.Length > 0 && textBox_SongName.Text.Length < 100)
                {
                    theSong.SongName = textBox_SongName.Text;                    
                    Error.SetError(textBox_SongName,"");
                }
                else                    
                    throw new System.ArgumentException();
            }
            catch
            {
                Error.SetError(textBox_SongName, "Song Name is required and must be less than 100 Characters...");
            }
        }

        private void textBox_ArtistName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_ArtistName.Text.Length > 0 && textBox_ArtistName.Text.Length < 100)
                {
                    theSong.ArtistName = textBox_ArtistName.Text;
                    Error2.SetError(textBox_ArtistName, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                Error2.SetError(textBox_ArtistName ,"Artist Name is required and must be less than 100 Characters...");
            }
        }

        private void textBox_AlbumName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_AlbumName.Text.Length > 0 && textBox_AlbumName.Text.Length < 100)
                {
                    theSong.AlbumName = textBox_AlbumName.Text;
                    Error3.SetError(textBox_AlbumName, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                Error3.SetError(textBox_AlbumName ,"Album Name is required and must be less than 100 Characters...");
            }
        }

        private void textBox_YearReleased_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_YearReleased.Text.Length == 0)
                {                    
                    theSong.YearReleased = 0;
                    Error4.SetError(textBox_YearReleased, "");
                }
                else if (Convert.ToInt32(textBox_YearReleased.Text) >= 1500 && Convert.ToInt32(textBox_YearReleased.Text) <= DateTime.Now.Year)
                {
                    theSong.YearReleased = Convert.ToInt32(textBox_YearReleased.Text);
                    Error4.SetError(textBox_YearReleased, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }                
            }
            catch
            {
                Error4.SetError(textBox_YearReleased ,"Your Year is outside of the parameters of a valid year");
            }
        }

        private void textBox_DurationInSeconds_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_DurationInSeconds.Text.Length == 0)
                {
                    theSong.DurationInSeconds = 0;
                    Error5.SetError(textBox_DurationInSeconds, "");
                }
                else if (Convert.ToInt32(textBox_DurationInSeconds.Text) >= 10 && Convert.ToInt32(textBox_DurationInSeconds.Text) <= 1000)
                {
                    theSong.DurationInSeconds = Convert.ToInt32(textBox_DurationInSeconds.Text);
                    Error5.SetError(textBox_DurationInSeconds, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }                
            }
            catch
            {
                Error5.SetError(textBox_DurationInSeconds ,"Your Duration is invalid...");
            }
        }

        private void textBox_TrackNumber_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_TrackNumber.Text.Length == 0)
                {
                    theSong.TrackNumber = 0;
                    Error6.SetError(textBox_TrackNumber, "");
                }
                else if (Convert.ToInt32(textBox_TrackNumber.Text) == 0)
                {
                    theSong.TrackNumber = 0;
                    Error6.SetError(textBox_TrackNumber, "");
                }
                else if (Convert.ToInt32(textBox_TrackNumber.Text) >= 1 && Convert.ToInt32(textBox_TrackNumber.Text) <= Convert.ToInt32(textBox_TrackCount.Text))
                {
                    theSong.TrackNumber = Convert.ToInt32(textBox_TrackNumber.Text);
                    Error6.SetError(textBox_TrackNumber, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                Error6.SetError(textBox_TrackNumber ,"Your Track Number is invalid...");
            }
        }

        private void textBox_TrackCount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox_TrackCount.Text.Length == 0)
                {
                    theSong.TrackCount = 0;
                    Error7.SetError(textBox_TrackCount, "");
                }
                else if (Convert.ToInt32(textBox_TrackCount.Text) >= 1 && Convert.ToInt32(textBox_TrackCount.Text) <= 1000)
                {
                    theSong.TrackCount = Convert.ToInt32(textBox_TrackCount.Text);
                    Error7.SetError(textBox_TrackCount, "");
                }
                else
                {
                    throw new System.ArgumentException();
                }
            }
            catch
            {
                Error7.SetError(textBox_TrackCount ,"Your Track Count is invalid...");
            }
        }

        private void textBox_Genre_Leave(object sender, EventArgs e)
        {
            try
            {
                theSong.Genre = textBox_Genre.Text;
            }
            catch {}
        }

        private void radioButton_Rating5_CheckedChanged(object sender, System.EventArgs e)
        {
            //theSong.MyRating = 5;
        }

        private void radioButton_Rating4_CheckedChanged(object sender, System.EventArgs e)
        {
            //theSong.MyRating = 4;
        }

        private void radioButton_Rating3_CheckedChanged(object sender, System.EventArgs e)
        {
            //theSong.MyRating = 3;
        }

        private void radioButton_Rating2_CheckedChanged(object sender, System.EventArgs e)
        {
            //theSong.MyRating = 2;
        }

        private void radioButton_Rating1_CheckedChanged(object sender, System.EventArgs e)
        {
            //theSong.MyRating = 1;
        }
        
    }
}
