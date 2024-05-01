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
    public partial class Form2 : Form
    {
        readonly Film film = new Film();
        public Form2(Film film)
        {
            InitializeComponent();

            this.film = film;
            NameBox.Text = film.Title;
            YearBox.Text = film.ReleaseYear.ToString();
            GenreBox.Text = film.Genres;
            DirectorBox.Text = film.Director;
            LocationBox.Text = film.Location;
            RatingBox.Text = film.Rating.ToString();
            SizeBox.Text = film.Size.ToString();
            StudioBox.Text = film.Studio.ToString();
            ActorBox.Text = film.Cast.ToString();
            SummaryBox.Text = film.Summary.ToString();
        }
    }
}
