namespace WinForms_Filmoteka
{
    public partial class Form1 : Form
    {
        FilmLibrary Library = new FilmLibrary();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string Title, string ReleaseYear, string Genre, string Director, string Location
            var result = Library.SearchFilms(NameBox.Text.Trim(), YearBox.Text.Trim(), GenreBox.Text.Trim(), DirectorBox.Text.Trim(), LocationBox.Text.Trim());

            filmBindingSource.DataSource = result;
        }
    }
}
