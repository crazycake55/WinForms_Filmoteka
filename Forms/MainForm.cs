using WinForms_Filmoteka.Forms;

namespace WinForms_Filmoteka
{
    public partial class MainForm : Form
    {
        FilmLibrary Library = new FilmLibrary("filmLibrary.json");
        List<FilmLibrary> Collections = new List<FilmLibrary>();
        FilmLibrary favourite = new FilmLibrary("favourite.json");
        FilmLibrary seen = new FilmLibrary("seen.json");


        public MainForm()
        {
            Library.LoadLibraryFromFile();
            favourite.LoadLibraryFromFile();
            seen.LoadLibraryFromFile();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Library.SearchFilms(NameBox.Text.Trim(), YearBox.Text.Trim(), GenreBox.Text.Trim(), DirectorBox.Text.Trim(), LocationBox.Text.Trim(), double.TryParse(SizeBox.Text.Trim(), out double num) ? num : null , ActorBox.Text.Trim(), StudioBox.Text.Trim(), float.TryParse(RatingBox.Text.Trim(), out float numb) ? numb : null);

            filmBindingSource.DataSource = result;
        }
        private void buttonLikeThis_Click(object sender, EventArgs e)
        {
            var result = new List<Film>();

            if (!string.IsNullOrEmpty(NameBox.Text.Trim()))
            {
                var nameResult = Library.SearchFilms(NameBox.Text.Trim(), "", "", "", "", null, "", "", null);
                result.AddRange(nameResult);
            }

            if (!string.IsNullOrEmpty(YearBox.Text.Trim()))
            {
                var yearResult = Library.SearchFilms("", YearBox.Text.Trim(), "", "", "", null, "", "", null);
                result.AddRange(yearResult);
            }

            if (!string.IsNullOrEmpty(GenreBox.Text.Trim()))
            {
                var genreResult = Library.SearchFilms("", "", GenreBox.Text.Trim(), "", "", null, "", "", null);
                result.AddRange(genreResult);
            }

            if (!string.IsNullOrEmpty(DirectorBox.Text.Trim()))
            {
                var directorResult = Library.SearchFilms("", "", "", DirectorBox.Text.Trim(), "", null, "", "", null);
                result.AddRange(directorResult);
            }

            if (!string.IsNullOrEmpty(LocationBox.Text.Trim()))
            {
                var locationResult = Library.SearchFilms("", "", "", "", LocationBox.Text.Trim(), null, "", "", null);
                result.AddRange(locationResult);
            }

            if (!string.IsNullOrEmpty(SizeBox.Text.Trim()))
            {
                double.TryParse(SizeBox.Text.Trim(), out double num);
                var sizeResult = Library.SearchFilms("", "", "", "", "", num, "", "", null);
                result.AddRange(sizeResult);
            }

            if (!string.IsNullOrEmpty(ActorBox.Text.Trim()))
            {
                var actorResult = Library.SearchFilms("", "", "", "", "", null, ActorBox.Text.Trim(), "", null);
                result.AddRange(actorResult);
            }

            if (!string.IsNullOrEmpty(StudioBox.Text.Trim()))
            {
                var studioResult = Library.SearchFilms("", "", "", "", "", null, "", StudioBox.Text.Trim(), null);
                result.AddRange(studioResult);
            }

            if (!string.IsNullOrEmpty(RatingBox.Text.Trim()))
            {
                float.TryParse(RatingBox.Text.Trim(), out float numb);
                var ratingResult = Library.SearchFilms("", "", "", "", "", null, "", "", numb);
                result.AddRange(ratingResult);
            }

            filmBindingSource.DataSource = result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Library.AddFilm(new Film
            {
                Title = NameBox.Text.Trim(),
                ReleaseYear = YearBox.Text.Trim(),
                Genres = GenreBox.Text.Trim(),
                Director = DirectorBox.Text.Trim(),
                Location = LocationBox.Text.Trim(),
                Summary = SummaryBox.Text.Trim(),
                Rating = float.Parse(RatingBox.Text.Trim()),
                Size = double.Parse(SizeBox.Text.Trim()),
                Studio = StudioBox.Text.Trim(),
                Cast = ActorBox.Text.Trim()
            });
        }

        private void î÷èñòèòèÏîëÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameBox.Text = string.Empty;
            YearBox.Text = string.Empty;
            GenreBox.Text = string.Empty;
            DirectorBox.Text = string.Empty;
            LocationBox.Text = string.Empty;
            RatingBox.Text = string.Empty;
            SizeBox.Text = string.Empty;
            StudioBox.Text = string.Empty;
            ActorBox.Text = string.Empty;
            SummaryBox.Text = string.Empty;
        }

        private void ResultListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ResultListBox.SelectedItems.Count > 0)
            {
                Film film = ResultListBox.SelectedItem as Film;
                var filmInfoForm = new SelectedForm(film, Library, Collections);
                filmInfoForm.Show();
            }
        }

    }
}