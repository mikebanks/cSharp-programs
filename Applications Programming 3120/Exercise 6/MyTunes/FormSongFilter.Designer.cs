namespace MyTunes
{
    partial class FormSongFilter
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
            this.labelSongName = new System.Windows.Forms.Label();
            this.labelMinYear = new System.Windows.Forms.Label();
            this.labelMaYear = new System.Windows.Forms.Label();
            this.labelMinRating = new System.Windows.Forms.Label();
            this.labelMaRating = new System.Windows.Forms.Label();
            this.textBoxSongName = new System.Windows.Forms.TextBox();
            this.textBoxMinYear = new System.Windows.Forms.TextBox();
            this.textBoxMaxYear = new System.Windows.Forms.TextBox();
            this.textBoxMinRating = new System.Windows.Forms.TextBox();
            this.textBoxMaxRating = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSongName
            // 
            this.labelSongName.AutoSize = true;
            this.labelSongName.Location = new System.Drawing.Point(12, 9);
            this.labelSongName.Name = "labelSongName";
            this.labelSongName.Size = new System.Drawing.Size(89, 20);
            this.labelSongName.TabIndex = 0;
            this.labelSongName.Text = "SongName";
            // 
            // labelMinYear
            // 
            this.labelMinYear.AutoSize = true;
            this.labelMinYear.Location = new System.Drawing.Point(12, 45);
            this.labelMinYear.Name = "labelMinYear";
            this.labelMinYear.Size = new System.Drawing.Size(68, 20);
            this.labelMinYear.TabIndex = 1;
            this.labelMinYear.Text = "MinYear";
            // 
            // labelMaYear
            // 
            this.labelMaYear.AutoSize = true;
            this.labelMaYear.Location = new System.Drawing.Point(12, 81);
            this.labelMaYear.Name = "labelMaYear";
            this.labelMaYear.Size = new System.Drawing.Size(72, 20);
            this.labelMaYear.TabIndex = 2;
            this.labelMaYear.Text = "MaxYear";
            // 
            // labelMinRating
            // 
            this.labelMinRating.AutoSize = true;
            this.labelMinRating.Location = new System.Drawing.Point(12, 117);
            this.labelMinRating.Name = "labelMinRating";
            this.labelMinRating.Size = new System.Drawing.Size(81, 20);
            this.labelMinRating.TabIndex = 3;
            this.labelMinRating.Text = "MinRating";
            // 
            // labelMaRating
            // 
            this.labelMaRating.AutoSize = true;
            this.labelMaRating.Location = new System.Drawing.Point(12, 153);
            this.labelMaRating.Name = "labelMaRating";
            this.labelMaRating.Size = new System.Drawing.Size(85, 20);
            this.labelMaRating.TabIndex = 4;
            this.labelMaRating.Text = "MaxRating";
            // 
            // textBoxSongName
            // 
            this.textBoxSongName.Location = new System.Drawing.Point(110, 6);
            this.textBoxSongName.Name = "textBoxSongName";
            this.textBoxSongName.Size = new System.Drawing.Size(166, 26);
            this.textBoxSongName.TabIndex = 5;
            // 
            // textBoxMinYear
            // 
            this.textBoxMinYear.Location = new System.Drawing.Point(110, 42);
            this.textBoxMinYear.Name = "textBoxMinYear";
            this.textBoxMinYear.Size = new System.Drawing.Size(166, 26);
            this.textBoxMinYear.TabIndex = 6;
            // 
            // textBoxMaxYear
            // 
            this.textBoxMaxYear.Location = new System.Drawing.Point(110, 78);
            this.textBoxMaxYear.Name = "textBoxMaxYear";
            this.textBoxMaxYear.Size = new System.Drawing.Size(166, 26);
            this.textBoxMaxYear.TabIndex = 7;
            // 
            // textBoxMinRating
            // 
            this.textBoxMinRating.Location = new System.Drawing.Point(110, 114);
            this.textBoxMinRating.Name = "textBoxMinRating";
            this.textBoxMinRating.Size = new System.Drawing.Size(166, 26);
            this.textBoxMinRating.TabIndex = 8;
            // 
            // textBoxMaxRating
            // 
            this.textBoxMaxRating.Location = new System.Drawing.Point(110, 150);
            this.textBoxMaxRating.Name = "textBoxMaxRating";
            this.textBoxMaxRating.Size = new System.Drawing.Size(166, 26);
            this.textBoxMaxRating.TabIndex = 9;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(415, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 27);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(415, 45);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSongFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 244);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxMaxRating);
            this.Controls.Add(this.textBoxMinRating);
            this.Controls.Add(this.textBoxMaxYear);
            this.Controls.Add(this.textBoxMinYear);
            this.Controls.Add(this.textBoxSongName);
            this.Controls.Add(this.labelMaRating);
            this.Controls.Add(this.labelMinRating);
            this.Controls.Add(this.labelMaYear);
            this.Controls.Add(this.labelMinYear);
            this.Controls.Add(this.labelSongName);
            this.Name = "FormSongFilter";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSongName;
        private System.Windows.Forms.Label labelMinYear;
        private System.Windows.Forms.Label labelMaYear;
        private System.Windows.Forms.Label labelMinRating;
        private System.Windows.Forms.Label labelMaRating;
        private System.Windows.Forms.TextBox textBoxSongName;
        private System.Windows.Forms.TextBox textBoxMinYear;
        private System.Windows.Forms.TextBox textBoxMaxYear;
        private System.Windows.Forms.TextBox textBoxMinRating;
        private System.Windows.Forms.TextBox textBoxMaxRating;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}