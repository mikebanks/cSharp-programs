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
    public partial class FormSongFilter : Form
    {
        SongFilter _SongFilter;
        public FormSongFilter(SongFilter filter)
        {
            InitializeComponent();
            textBoxSongName.Text = filter.SongName;
            textBoxMinYear.Text = filter.MinYear;
            textBoxMaxYear.Text = filter.MaxYear;
            textBoxMinRating.Text = filter.MinRating;
            textBoxMaxRating.Text = filter.MaxRating;
            _SongFilter = filter;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _SongFilter.SongName = textBoxSongName.Text;
            _SongFilter.MinYear = textBoxMinYear.Text;
            _SongFilter.MaxYear = textBoxMaxYear.Text;
            _SongFilter.MinRating = textBoxMinRating.Text;
            _SongFilter.MaxRating = textBoxMaxRating.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
