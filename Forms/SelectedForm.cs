using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinForms_Filmoteka.Forms
{
    public partial class SelectedForm : Form
    {
        MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
        Film film = new Film();
        FilmLibrary library = new FilmLibrary("");
        FilmLibrary Seen = new FilmLibrary("");
        FilmLibrary WantTo = new FilmLibrary("");
        public SelectedForm(Film film, FilmLibrary Library, FilmLibrary seen, FilmLibrary wantTo)
        {
            InitializeComponent();

            this.library = Library;
            this.film = film;
            this.Seen = seen;
            this.WantTo = wantTo;
            NameBox.Text = film.Title;
            YearBox.Text = film.ReleaseYear.ToString();
            GenreBox.Text = film.Genres;
            DirectorBox.Text = film.Director;
            LocationBox.Text = film.Location;
            RatingBox.Text = film.Rating.ToString();
            SizeBox.Text = film.Size.ToString();
            StudioBox.Text = film.Studio.ToString();
            ActorBox.Text = film.Cast;
            SummaryBox.Text = film.Summary.ToString();

            if (Seen.films.Contains(film))
            {
                comboBox1.SelectedIndex = 1;
            }
            else if (WantTo.films.Contains(film))
            {
                comboBox1.SelectedIndex = 2;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }

            NameBox.Enabled = false;
            YearBox.Enabled = false;
            GenreBox.Enabled = false;
            DirectorBox.Enabled = false;
            LocationBox.Enabled = false;
            RatingBox.Enabled = false;
            SizeBox.Enabled = false;
            StudioBox.Enabled = false;
            ActorBox.Enabled = false;
            SummaryBox.Enabled = false;
            buttonSave.Enabled = false;
            comboBox1.Enabled = false;
            buttonDelete.Enabled = false;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            film.Title = NameBox.Text.Trim();
            film.ReleaseYear = YearBox.Text.Trim();
            film.Genres = GenreBox.Text.Trim();
            film.Director = DirectorBox.Text.Trim();
            film.Location = LocationBox.Text.Trim();
            film.Rating = float.TryParse(RatingBox.Text.Trim(), out float parsedValue) ? parsedValue : (float?)null;
            film.Size = double.TryParse(SizeBox.Text.Trim(), out double parsedValue1) ? parsedValue1 : (double?)null;
            film.Studio = StudioBox.Text.Trim();
            film.Cast = ActorBox.Text.Trim();
            film.Summary = SummaryBox.Text.Trim();
            library.SaveLibraryToFile();
            if (comboBox1.SelectedIndex == 1)
            {
                Seen.AddFilm(film);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                WantTo.AddFilm(film);
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                WantTo.RemoveFilm(film);
                Seen.RemoveFilm(film);
            }

            this.Close();
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            YearBox.Enabled = true;
            GenreBox.Enabled = true;
            DirectorBox.Enabled = true;
            LocationBox.Enabled = true;
            RatingBox.Enabled = true;
            SizeBox.Enabled = true;
            StudioBox.Enabled = true;
            ActorBox.Enabled = true;
            SummaryBox.Enabled = true;
            buttonSave.Enabled = true;
            comboBox1.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            library.RemoveFilm(film);
            this.Close();
        }

        private void SelectedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.SelectedForm_FormClosed();
        }
    }
}
