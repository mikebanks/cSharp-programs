namespace MyTunes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_SongName = new System.Windows.Forms.TextBox();
            this.textBox_ArtistName = new System.Windows.Forms.TextBox();
            this.textBox_AlbumName = new System.Windows.Forms.TextBox();
            this.textBox_YearReleased = new System.Windows.Forms.TextBox();
            this.textBox_DurationInSeconds = new System.Windows.Forms.TextBox();
            this.textBox_TrackNumber = new System.Windows.Forms.TextBox();
            this.textBox_TrackCount = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.label_SongName = new System.Windows.Forms.Label();
            this.label_ArtistName = new System.Windows.Forms.Label();
            this.label_AlbumName = new System.Windows.Forms.Label();
            this.label_YearReleased = new System.Windows.Forms.Label();
            this.label_DurationInSeconds = new System.Windows.Forms.Label();
            this.label_TrackNumber = new System.Windows.Forms.Label();
            this.label_TrackCount = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.radioButton_Rating1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Rating2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Rating3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Rating4 = new System.Windows.Forms.RadioButton();
            this.radioButton_Rating5 = new System.Windows.Forms.RadioButton();
            this.label_Rating = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_SongName
            // 
            this.textBox_SongName.Location = new System.Drawing.Point(135, 58);
            this.textBox_SongName.Name = "textBox_SongName";
            this.textBox_SongName.Size = new System.Drawing.Size(542, 31);
            this.textBox_SongName.TabIndex = 0;
            this.textBox_SongName.TextChanged += new System.EventHandler(this.textBox_SongName_Leave);
            // 
            // textBox_ArtistName
            // 
            this.textBox_ArtistName.Location = new System.Drawing.Point(135, 160);
            this.textBox_ArtistName.Name = "textBox_ArtistName";
            this.textBox_ArtistName.Size = new System.Drawing.Size(316, 31);
            this.textBox_ArtistName.TabIndex = 1;
            this.textBox_ArtistName.Leave += new System.EventHandler(this.textBox_ArtistName_Leave);
            // 
            // textBox_AlbumName
            // 
            this.textBox_AlbumName.Location = new System.Drawing.Point(135, 267);
            this.textBox_AlbumName.Name = "textBox_AlbumName";
            this.textBox_AlbumName.Size = new System.Drawing.Size(316, 31);
            this.textBox_AlbumName.TabIndex = 2;
            this.textBox_AlbumName.Leave += new System.EventHandler(this.textBox_AlbumName_Leave);
            // 
            // textBox_YearReleased
            // 
            this.textBox_YearReleased.Location = new System.Drawing.Point(135, 367);
            this.textBox_YearReleased.Name = "textBox_YearReleased";
            this.textBox_YearReleased.Size = new System.Drawing.Size(316, 31);
            this.textBox_YearReleased.TabIndex = 3;
            this.textBox_YearReleased.Leave += new System.EventHandler(this.textBox_YearReleased_Leave);
            // 
            // textBox_DurationInSeconds
            // 
            this.textBox_DurationInSeconds.Location = new System.Drawing.Point(857, 58);
            this.textBox_DurationInSeconds.Name = "textBox_DurationInSeconds";
            this.textBox_DurationInSeconds.Size = new System.Drawing.Size(198, 31);
            this.textBox_DurationInSeconds.TabIndex = 4;
            this.textBox_DurationInSeconds.Leave += new System.EventHandler(this.textBox_DurationInSeconds_Leave);
            // 
            // textBox_TrackNumber
            // 
            this.textBox_TrackNumber.Location = new System.Drawing.Point(857, 159);
            this.textBox_TrackNumber.Name = "textBox_TrackNumber";
            this.textBox_TrackNumber.Size = new System.Drawing.Size(256, 31);
            this.textBox_TrackNumber.TabIndex = 5;
            this.textBox_TrackNumber.Leave += new System.EventHandler(this.textBox_TrackNumber_Leave);
            // 
            // textBox_TrackCount
            // 
            this.textBox_TrackCount.Location = new System.Drawing.Point(857, 266);
            this.textBox_TrackCount.Name = "textBox_TrackCount";
            this.textBox_TrackCount.Size = new System.Drawing.Size(256, 31);
            this.textBox_TrackCount.TabIndex = 6;
            this.textBox_TrackCount.Leave += new System.EventHandler(this.textBox_TrackCount_Leave);
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(857, 366);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(256, 31);
            this.textBox_Genre.TabIndex = 7;
            this.textBox_Genre.Leave += new System.EventHandler(this.textBox_Genre_Leave);
            // 
            // label_SongName
            // 
            this.label_SongName.AutoSize = true;
            this.label_SongName.Location = new System.Drawing.Point(25, 58);
            this.label_SongName.Name = "label_SongName";
            this.label_SongName.Size = new System.Drawing.Size(68, 25);
            this.label_SongName.TabIndex = 8;
            this.label_SongName.Text = "Name";
            // 
            // label_ArtistName
            // 
            this.label_ArtistName.AutoSize = true;
            this.label_ArtistName.Location = new System.Drawing.Point(25, 163);
            this.label_ArtistName.Name = "label_ArtistName";
            this.label_ArtistName.Size = new System.Drawing.Size(61, 25);
            this.label_ArtistName.TabIndex = 9;
            this.label_ArtistName.Text = "Artist";
            // 
            // label_AlbumName
            // 
            this.label_AlbumName.AutoSize = true;
            this.label_AlbumName.Location = new System.Drawing.Point(25, 271);
            this.label_AlbumName.Name = "label_AlbumName";
            this.label_AlbumName.Size = new System.Drawing.Size(72, 25);
            this.label_AlbumName.TabIndex = 10;
            this.label_AlbumName.Text = "Album";
            // 
            // label_YearReleased
            // 
            this.label_YearReleased.AutoSize = true;
            this.label_YearReleased.Location = new System.Drawing.Point(25, 371);
            this.label_YearReleased.Name = "label_YearReleased";
            this.label_YearReleased.Size = new System.Drawing.Size(58, 25);
            this.label_YearReleased.TabIndex = 11;
            this.label_YearReleased.Text = "Year";
            this.label_YearReleased.Click += new System.EventHandler(this.label_YearReleased_Click);
            // 
            // label_DurationInSeconds
            // 
            this.label_DurationInSeconds.AutoSize = true;
            this.label_DurationInSeconds.Location = new System.Drawing.Point(743, 58);
            this.label_DurationInSeconds.Name = "label_DurationInSeconds";
            this.label_DurationInSeconds.Size = new System.Drawing.Size(93, 25);
            this.label_DurationInSeconds.TabIndex = 12;
            this.label_DurationInSeconds.Text = "Duration";
            // 
            // label_TrackNumber
            // 
            this.label_TrackNumber.AutoSize = true;
            this.label_TrackNumber.Location = new System.Drawing.Point(743, 164);
            this.label_TrackNumber.Name = "label_TrackNumber";
            this.label_TrackNumber.Size = new System.Drawing.Size(66, 25);
            this.label_TrackNumber.TabIndex = 13;
            this.label_TrackNumber.Text = "Track";
            // 
            // label_TrackCount
            // 
            this.label_TrackCount.AutoSize = true;
            this.label_TrackCount.Location = new System.Drawing.Point(743, 270);
            this.label_TrackCount.Name = "label_TrackCount";
            this.label_TrackCount.Size = new System.Drawing.Size(69, 25);
            this.label_TrackCount.TabIndex = 14;
            this.label_TrackCount.Text = "Count";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(743, 369);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(71, 25);
            this.label_Genre.TabIndex = 15;
            this.label_Genre.Text = "Genre";
            // 
            // radioButton_Rating1
            // 
            this.radioButton_Rating1.AutoSize = true;
            this.radioButton_Rating1.Location = new System.Drawing.Point(135, 449);
            this.radioButton_Rating1.Name = "radioButton_Rating1";
            this.radioButton_Rating1.Size = new System.Drawing.Size(55, 29);
            this.radioButton_Rating1.TabIndex = 16;
            this.radioButton_Rating1.TabStop = true;
            this.radioButton_Rating1.Text = "1";
            this.radioButton_Rating1.UseVisualStyleBackColor = true;
            this.radioButton_Rating1.CheckedChanged += new System.EventHandler(this.radioButton_Rating1_CheckedChanged);
            // 
            // radioButton_Rating2
            // 
            this.radioButton_Rating2.AutoSize = true;
            this.radioButton_Rating2.Location = new System.Drawing.Point(197, 449);
            this.radioButton_Rating2.Name = "radioButton_Rating2";
            this.radioButton_Rating2.Size = new System.Drawing.Size(55, 29);
            this.radioButton_Rating2.TabIndex = 17;
            this.radioButton_Rating2.TabStop = true;
            this.radioButton_Rating2.Text = "2";
            this.radioButton_Rating2.UseVisualStyleBackColor = true;
            this.radioButton_Rating2.CheckedChanged += new System.EventHandler(this.radioButton_Rating2_CheckedChanged);
            // 
            // radioButton_Rating3
            // 
            this.radioButton_Rating3.AutoSize = true;
            this.radioButton_Rating3.Location = new System.Drawing.Point(259, 448);
            this.radioButton_Rating3.Name = "radioButton_Rating3";
            this.radioButton_Rating3.Size = new System.Drawing.Size(55, 29);
            this.radioButton_Rating3.TabIndex = 18;
            this.radioButton_Rating3.TabStop = true;
            this.radioButton_Rating3.Text = "3";
            this.radioButton_Rating3.UseVisualStyleBackColor = true;
            this.radioButton_Rating3.CheckedChanged += new System.EventHandler(this.radioButton_Rating3_CheckedChanged);
            // 
            // radioButton_Rating4
            // 
            this.radioButton_Rating4.AutoSize = true;
            this.radioButton_Rating4.Location = new System.Drawing.Point(321, 448);
            this.radioButton_Rating4.Name = "radioButton_Rating4";
            this.radioButton_Rating4.Size = new System.Drawing.Size(55, 29);
            this.radioButton_Rating4.TabIndex = 19;
            this.radioButton_Rating4.TabStop = true;
            this.radioButton_Rating4.Text = "4";
            this.radioButton_Rating4.UseVisualStyleBackColor = true;
            this.radioButton_Rating4.CheckedChanged += new System.EventHandler(this.radioButton_Rating4_CheckedChanged);
            // 
            // radioButton_Rating5
            // 
            this.radioButton_Rating5.AutoSize = true;
            this.radioButton_Rating5.Location = new System.Drawing.Point(383, 449);
            this.radioButton_Rating5.Name = "radioButton_Rating5";
            this.radioButton_Rating5.Size = new System.Drawing.Size(55, 29);
            this.radioButton_Rating5.TabIndex = 20;
            this.radioButton_Rating5.TabStop = true;
            this.radioButton_Rating5.Text = "5";
            this.radioButton_Rating5.UseVisualStyleBackColor = true;
            this.radioButton_Rating5.CheckedChanged += new System.EventHandler(this.radioButton_Rating5_CheckedChanged);
            // 
            // label_Rating
            // 
            this.label_Rating.AutoSize = true;
            this.label_Rating.Location = new System.Drawing.Point(30, 449);
            this.label_Rating.Name = "label_Rating";
            this.label_Rating.Size = new System.Drawing.Size(74, 25);
            this.label_Rating.TabIndex = 21;
            this.label_Rating.Text = "Rating";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(1232, 464);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(153, 42);
            this.button_OK.TabIndex = 22;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(1232, 529);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(153, 42);
            this.button_Cancel.TabIndex = 23;
            this.button_Cancel.TabStop = false;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(515, 529);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 25);
            this.StatusLabel.TabIndex = 24;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 583);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_Rating);
            this.Controls.Add(this.radioButton_Rating5);
            this.Controls.Add(this.radioButton_Rating4);
            this.Controls.Add(this.radioButton_Rating3);
            this.Controls.Add(this.radioButton_Rating2);
            this.Controls.Add(this.radioButton_Rating1);
            this.Controls.Add(this.label_Genre);
            this.Controls.Add(this.label_TrackCount);
            this.Controls.Add(this.label_TrackNumber);
            this.Controls.Add(this.label_DurationInSeconds);
            this.Controls.Add(this.label_YearReleased);
            this.Controls.Add(this.label_AlbumName);
            this.Controls.Add(this.label_ArtistName);
            this.Controls.Add(this.label_SongName);
            this.Controls.Add(this.textBox_Genre);
            this.Controls.Add(this.textBox_TrackCount);
            this.Controls.Add(this.textBox_TrackNumber);
            this.Controls.Add(this.textBox_DurationInSeconds);
            this.Controls.Add(this.textBox_YearReleased);
            this.Controls.Add(this.textBox_AlbumName);
            this.Controls.Add(this.textBox_ArtistName);
            this.Controls.Add(this.textBox_SongName);
            this.Name = "Form1";
            this.Text = "MyTunes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void label_YearReleased_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SongName;
        private System.Windows.Forms.TextBox textBox_ArtistName;
        private System.Windows.Forms.TextBox textBox_AlbumName;
        private System.Windows.Forms.TextBox textBox_YearReleased;
        private System.Windows.Forms.TextBox textBox_DurationInSeconds;
        private System.Windows.Forms.TextBox textBox_TrackNumber;
        private System.Windows.Forms.TextBox textBox_TrackCount;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.Label label_SongName;
        private System.Windows.Forms.Label label_ArtistName;
        private System.Windows.Forms.Label label_AlbumName;
        private System.Windows.Forms.Label label_YearReleased;
        private System.Windows.Forms.Label label_DurationInSeconds;
        private System.Windows.Forms.Label label_TrackNumber;
        private System.Windows.Forms.Label label_TrackCount;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.RadioButton radioButton_Rating1;
        private System.Windows.Forms.RadioButton radioButton_Rating2;
        private System.Windows.Forms.RadioButton radioButton_Rating3;
        private System.Windows.Forms.RadioButton radioButton_Rating4;
        private System.Windows.Forms.RadioButton radioButton_Rating5;
        private System.Windows.Forms.Label label_Rating;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label StatusLabel;
    }
}

