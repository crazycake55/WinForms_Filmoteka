using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using WinForms_Filmoteka.Forms;

namespace WinForms_Filmoteka
{
    public partial class MainForm : Form
    {
        FilmLibrary Library = new FilmLibrary("filmLibrary.json");
        List<FilmLibrary> Collections = new List<FilmLibrary>();
        FilmLibrary wantTo = new FilmLibrary("wantTo.json");
        FilmLibrary seen = new FilmLibrary("seen.json");


        public MainForm()
        {
            Library.LoadLibraryFromFile();
            wantTo.LoadLibraryFromFile();
            seen.LoadLibraryFromFile();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Library.SearchFilms(NameBox.Text.Trim(), YearBox.Text.Trim(), GenreBox.Text.Trim(), DirectorBox.Text.Trim(), LocationBox.Text.Trim(), double.TryParse(SizeBox.Text.Trim(), out double num) ? num : null, ActorBox.Text.Trim(), StudioBox.Text.Trim(), float.TryParse(RatingBox.Text.Trim(), out float numb) ? numb : null);

            filmBindingSource.DataSource = result;
        }
        private void buttonLikeThis_Click(object sender, EventArgs e)
        {
            var result = new List<Film>();

            if (!string.IsNullOrEmpty(NameBox.Text.Trim()))
            {
                var nameResult = Library.SearchFilms(NameBox.Text.Trim(), "", "", "", "", null, "", "", null);
                
                foreach(var film in nameResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
            }

            if (!string.IsNullOrEmpty(YearBox.Text.Trim()))
            {
                var yearResult = Library.SearchFilms("", YearBox.Text.Trim(), "", "", "", null, "", "", null);
                foreach (var film in yearResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
            }

            if (!string.IsNullOrEmpty(GenreBox.Text.Trim()))
            {
                var genreResult = Library.SearchFilms("", "", GenreBox.Text.Trim(), "", "", null, "", "", null);
                foreach (var film in genreResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
            }

            if (!string.IsNullOrEmpty(DirectorBox.Text.Trim()))
            {
                var directorResult = Library.SearchFilms("", "", "", DirectorBox.Text.Trim(), "", null, "", "", null);
                foreach (var film in directorResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
            }

            if (!string.IsNullOrEmpty(LocationBox.Text.Trim()))
            {
                var locationResult = Library.SearchFilms("", "", "", "", LocationBox.Text.Trim(), null, "", "", null);
                foreach (var film in locationResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
            }

            if (!string.IsNullOrEmpty(SizeBox.Text.Trim()))
            {
                double.TryParse(SizeBox.Text.Trim(), out double num);
                var sizeResult = Library.SearchFilms("", "", "", "", "", num, "", "", null);
                foreach (var film in sizeResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
            }

            if (!string.IsNullOrEmpty(ActorBox.Text.Trim()))
            {
                var actorResult = Library.SearchFilms("", "", "", "", "", null, ActorBox.Text.Trim(), "", null);
                foreach (var film in actorResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
            }

            if (!string.IsNullOrEmpty(StudioBox.Text.Trim()))
            {
                var studioResult = Library.SearchFilms("", "", "", "", "", null, "", StudioBox.Text.Trim(), null);
                foreach (var film in studioResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
            }

            if (!string.IsNullOrEmpty(RatingBox.Text.Trim()))
            {
                float.TryParse(RatingBox.Text.Trim(), out float numb);
                var ratingResult = Library.SearchFilms("", "", "", "", "", null, "", "", numb);
                foreach (var film in ratingResult)
                {
                    if (!result.Contains(film))
                    {
                        result.Add(film);
                    }
                }
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
                Rating = float.TryParse(RatingBox.Text.Trim(), out float parsedValue) ? parsedValue : (float?)null,
                Size = double.TryParse(SizeBox.Text.Trim(), out double parsedValue1) ? parsedValue1 : (double?)null,
                Studio = StudioBox.Text.Trim(),
                Cast = ActorBox.Text.Trim()
            });
        }

        private void Ó˜ËÒÚËÚËœÓÎˇToolStripMenuItem_Click(object sender, EventArgs e)
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
                var filmInfoForm = new SelectedForm(film, Library, Collections, seen, wantTo);
                filmInfoForm.Show();
            }
        }

        private void seenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = seen.SearchFilms("", "", "", "", "", null, "", "", null);

            filmBindingSource.DataSource = result;
        }

        private void ıÓ˜ÛœÂÂ„ÎˇÌÛÚËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = wantTo.SearchFilms("", "", "", "", "", null, "", "", null);

            filmBindingSource.DataSource = result;
        }

        private void RatingBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void SizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Á·ÂÂ„ÚËﬂÍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveObjectToJson(Library);
        }

        private void SaveObjectToJson(FilmLibrary obj)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    string json = JsonSerializer.Serialize(obj.films);

                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Œ·'∫ÍÚ Á·ÂÂÊÂÌÓ Û JSON Ù‡ÈÎ.");
                }
            }
        }

        private void LoadObjectFromJson()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    Library.filePath = selectedFilePath;
                    Library.LoadLibraryFromFile();
                    MessageBox.Show("¬˚·‡ÌÓ JSON-Ù‡ÈÎ: " + selectedFilePath);
                }
            }
        }

        private void Á‡‚‡ÌÚ‡ÊËÚË«ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadObjectFromJson();
        }

        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}