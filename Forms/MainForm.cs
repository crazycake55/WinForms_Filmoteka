using WinForms_Filmoteka.Forms;

namespace WinForms_Filmoteka
{
    public partial class MainForm : Form
    {
        FilmLibrary Library = new FilmLibrary();
        
        public MainForm()
        {
            Library.LoadLibraryFromFile();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string Title, string ReleaseYear, string Genre, string Director, string Location
            var result = Library.SearchFilms(NameBox.Text.Trim(), YearBox.Text.Trim(), GenreBox.Text.Trim(), DirectorBox.Text.Trim(), LocationBox.Text.Trim());

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
                Cast = ActorBox.Text.Trim().Split(", ").ToList()
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
            if(ResultListBox.SelectedItems.Count > 0)
            {
                Film film = ResultListBox.SelectedItem as Film;
                var filmInfoForm = new SelectedForm(film);
                filmInfoForm.Show();
            }
        }
    }
}
