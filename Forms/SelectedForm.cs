using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Filmoteka.Forms
{
    public partial class SelectedForm : Form
    {
        Film film = new Film();
        FilmLibrary library = new FilmLibrary("");
        List<FilmLibrary> collections = new List<FilmLibrary>();
        FilmLibrary Seen = new FilmLibrary("");
        FilmLibrary WantTo = new FilmLibrary("");
        public SelectedForm(Film film, FilmLibrary Library, List<FilmLibrary> Collections, FilmLibrary seen, FilmLibrary wantTo)
        {
            InitializeComponent();

            this.collections = Collections;
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
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            film.Title = NameBox.Text.Trim();
            film.ReleaseYear = YearBox.Text.Trim();
            film.Genres = GenreBox.Text.Trim();
            film.Director = DirectorBox.Text.Trim();
            film.Location = LocationBox.Text.Trim();
            film.Rating = float.Parse(RatingBox.Text.Trim());
            film.Size = double.Parse(SizeBox.Text.Trim());
            film.Studio = StudioBox.Text.Trim();
            film.Cast = ActorBox.Text.Trim();
            film.Summary = SummaryBox.Text.Trim();
            library.SaveLibraryToFile();
            if(comboBox1.SelectedIndex == 1)
            {
                Seen.AddFilm(film);
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                WantTo.AddFilm(film);
            }
            else if(comboBox1.SelectedIndex == 0)
            {
                WantTo.RemoveFilm(film);
                Seen.RemoveFilm(film);
            }

            this.Close();
        }

    }
}
