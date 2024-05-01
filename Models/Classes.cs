using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Film
{
    public string Title { get; set; }
    public string Studio { get; set; }
    public string Genres { get; set; }
    public string ReleaseYear { get; set; }
    public string Director { get; set; }
    public List<string> Cast { get; set; }
    public string Summary { get; set; }
    public float Rating { get; set; }
    public string Location { get; set; }
    public double Size { get; set; }
}

public class FilmLibrary
{
    public List<Film> films;
    private string filePath = "filmLibrary.json";

    public FilmLibrary()
    {
        films = new List<Film>();
        this.Fill();
    }

    public void AddFilm(Film film)
    {
        films.Add(film);
        SaveLibraryToFile();
    }

    void Fill()
    {
        for(int i = 0; i <= 10; i++)
        {
            this.AddFilm(new Film
            {
                Title = $"Title{i}",
                Studio = $"Studio{i}",
                Genres = "Action, Drama",
                ReleaseYear = $"{i}",
                Director = $"Director{i}",
                Cast = new List<string> { "actor1", "actor2"},
                Summary = "summary",
                Rating = i,
                Location = $"Location{i}",
                Size = i * 60
            });
        }
    }

    public void SaveLibraryToFile()
    {
        string json = JsonSerializer.Serialize(films);
        File.WriteAllText(filePath, json);
    }

    public void LoadLibraryFromFile()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            films = JsonSerializer.Deserialize<List<Film>>(json);
        }
    }

    public bool CheckFilmAvailability(string title)
    {
        return films.Exists(f => f.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public List<Film> SearchFilms(string Title, string ReleaseYear, string Genre, string Director, string Location)
    {

        //
        var result = new List<Film>();
        foreach (var f in films)
        {
            // && f.Genres.Contains(Genre) && f.Director.Contains(Director) && f.Location.Contains(Location)
            if (f.Title.Contains(Title) && f.ReleaseYear.Contains(ReleaseYear) && f.Genres.Contains(Genre) && (string.IsNullOrEmpty(Location) || f.Location.Contains(Location)) && f.Director.Contains(Director))
            {
                result.Add(f);
            }
        }
        return result;
    }

    /*public void SearchFilmsByGenres(List<string> genres)
    {
        if (genres == null || genres.Count == 0)
        {
            Console.WriteLine("Список жанрів для пошуку порожній.");
            return;
        }

        List<Film> foundFilms = films.FindAll(film => film.Genres.All(genres.Contains));

        if (foundFilms.Count > 0)
        {
            Console.WriteLine("Знайдені фільми за жанрами:");
            foreach (var film in foundFilms)
            {
                Console.WriteLine($"Назва: {film.Title}, Жанри: {string.Join(", ", film.Genres)}, Рік: {film.ReleaseYear}");
            }
        }
        else
        {
            Console.WriteLine("Фільми за вказаними жанрами не знайдені.");
        }
    }*/


    public void ClearLibrary()
    {
        films.Clear();
        SaveLibraryToFile();
    }
}