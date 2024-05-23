using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using WinForms_Filmoteka.Forms;

namespace WinForms_Filmoteka
{
    public partial class MainForm : Form
    {
        FilmLibrary Library = new FilmLibrary("filmLibrary.json");
        FilmLibrary wantTo = new FilmLibrary("wantTo.json");
        FilmLibrary seen = new FilmLibrary("seen.json");


        public MainForm()
        {
            Library.LoadLibraryFromFile();
            wantTo.LoadLibraryFromFile();
            seen.LoadLibraryFromFile();
            InitializeComponent();
            filmBindingSource.DataSource = Library.films;
        }

        /*Після натиску кнопки «Пошук» зчитує дані, введені у полях цієї форми, та на їх основі
        виводить новий список фільмів, які підходять під всі критерії пошуку.*/
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var result = Library.SearchFilms(NameBox.Text.Trim(), YearBox.Text.Trim(), GenreBox.Text.Trim(), DirectorBox.Text.Trim(), LocationBox.Text.Trim(), double.TryParse(SizeBox.Text.Trim(), out double num) ? num : null, ActorBox.Text.Trim(), StudioBox.Text.Trim(), float.TryParse(RatingBox.Text.Trim(), out float numb) ? numb : null);

            filmBindingSource.DataSource = result;
        }

        /*після натиску кнопки «Знайти схожі на цей» зчитує дані, введені у полях цієї форми, та на
        їх основі виводить новий список фільмів, які підходять під один чи більше критеріїв пошуку.*/
        private void buttonLikeThis_Click(object sender, EventArgs e)
        {
            var result = new List<Film>();

            if (!string.IsNullOrEmpty(NameBox.Text.Trim()))
            {
                var nameResult = Library.SearchFilms(NameBox.Text.Trim(), "", "", "", "", null, "", "", null);

                foreach (var film in nameResult)
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

        /*після натиску кнопки «Внести новий фільм» зчитує дані, введені у полях цієї форми, та на
        їх основі додає до основної бібліотеки новий фільм з веденими у поля даними.*/
        private void buttonAddFilm_Click(object sender, EventArgs e)
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

            filmBindingSource.DataSource = Library.films;
        }

        /*після натиску кнопки «Очистити поля» з вкладки на стрічці меню
        «Інструменти» очищає всі поля вводу на формі.*/
        private void ClearFormToolStripMenuItem_Click(object sender, EventArgs e)
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

        /*після подвійного кліку на фільм зі списку відкриває іншу форму з інформацією про фільм*/
        private void ResultListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ResultListBox.SelectedItems.Count > 0)
            {
                Film film = ResultListBox.SelectedItem as Film;
                var filmInfoForm = new SelectedForm(film, Library, seen, wantTo);
                filmInfoForm.Show();
            }

        }

        /*оновлює джерело списку фільмів*/
        public void SelectedForm_FormClosed()
        {
            filmBindingSource.DataSource = Library.films;
        }

        /*після натиску кнопки «Переглянув» з вкладки на стрічці меню «Колекції» змінює
        видимий список фільмів на список переглянутих.*/
        private void seenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = seen.SearchFilms("", "", "", "", "", null, "", "", null);

            filmBindingSource.DataSource = result;
        }

        /*після натиску кнопки «Хочу переглянути» з вкладки на стрічці меню «Колекції»
        змінює видимий список фільмів на список бажаних до перегляду.*/
        private void wantToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = wantTo.SearchFilms("", "", "", "", "", null, "", "", null);

            filmBindingSource.DataSource = result;
        }

        /*відслідковує ввід у поле з значенням рейтингу фільму, щоб користувач міг ввести
        лише цифри та одну кому.*/
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

        /*відслідковує ввід у поле з значенням часу фільму, щоб користувач міг ввести лише цифри.*/
        private void SizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*після натиску кнопки «Зберегти бібліотеку як...» з вкладки на стрічці меню
        «Файл» зберігає поточну бібліотеку у JSON файл за шляхом, який вкаже користувач.*/
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveObjectToJson(Library);
        }

        /*отримує на вхід бібліотеку фільмів та зберігає її у JSON файл, шлях до якого вкаже користувач.Є
        частиною інших методів, які пов’язані зі збереженням списків у JSON файли.*/
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

                    MessageBox.Show("Об'єкт збережено у JSON файл.");
                }
            }
        }

        /*завантажує бібліотеку фільмів з файлу, який знаходиться за шляхом у полі «filePath».*/
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
                    MessageBox.Show("Выбрано JSON-файл: " + selectedFilePath);
                }
            }
        }

        /*після натиску кнопки «Завантажити з...» з вкладки на стрічці меню
        «Файл» заміняє поточну бібліотеку на іншу, з файлу за шляхом, який вкаже користувач.*/
        private void loadFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadObjectFromJson();
        }

        /*відслідковує ввід у поле з значенням року фільму, щоб користувач міг ввести лише цифри.*/
        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*після натиску кнопки «Поділитись переглянутим» з вкладки на стрічці меню «Колекції» зберігає
        список переглянутих фільмів у JSON файл за шляхом, який вкаже користувач.*/
        private void shareSeenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveObjectToJson(seen);
        }

        /*після натиску кнопки «Поділитись бажаним» з вкладки на стрічці меню «Колекції» зберігає
        список бажаних до перегляду фільмів у JSON файл за шляхом, який вкаже користувач.*/
        private void shareWantToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveObjectToJson(wantTo);
        }

        /*після натиску кнопки «Зберегти результат пошуку як...» з вкладки на
        стрічці меню «Файл» зберігає поточний результат пошуку у JSON файл
        за шляхом, який вкаже користувач.*/
        private void saveSearchResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmLibrary temp = new FilmLibrary("");
            temp.films = (List<Film>)filmBindingSource.DataSource;
            SaveObjectToJson(temp);
        }

        /*після натиску кнопки «Видалити поточну бібліотеку» з вкладки на
        стрічці меню «Інструменти» очищає поточну бібліотеку.*/
        private void deleteLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library.ClearLibrary();
            SelectedForm_FormClosed();
        }
    }
}