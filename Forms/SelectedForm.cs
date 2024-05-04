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
        public SelectedForm(Film film, FilmLibrary Library, List<FilmLibrary> Collections)
        {
            InitializeComponent();

            this.collections = Collections;
            this.library = Library;
            this.film = film;
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
        }

        private void buttonAddTo_Click(object sender, EventArgs e)
        {

        }
    }
}
