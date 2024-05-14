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
    public string Cast { get; set; }
    public string Summary { get; set; }
    public float Rating { get; set; }
    public string Location { get; set; }
    public double Size { get; set; }
}

public class FilmLibrary
{
    public List<Film> films;
    private string filePath;

    public FilmLibrary(string path)
    {
        films = new List<Film>();
        filePath = path;
        /*this.Fill();*/
    }

    public void AddFilm(Film film)
    {
        films.Add(film);
        SaveLibraryToFile();
    }

    public void Fill()
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
                Cast = "actor1, actor2",
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

    public List<Film> SearchFilms(string Title, string ReleaseYear, string Genre, string Director, string Location, double? Size, string Cast, string Studio, float? Rating)
    {

        var result = new List<Film>();
        foreach (var f in films)
        {
            if (f.Title.Contains(Title) && f.ReleaseYear.Contains(ReleaseYear) && f.Genres.Contains(Genre) 
                && CheckIfAllElementsInString(Location.Split(", "), f.Location) && f.Director.Contains(Director) && (f.Size == Size || Size == null) 
                && CheckIfAllElementsInString(Cast.Split(", "), f.Cast) && f.Studio.Contains(Studio) && (f.Rating == Rating || Rating == null))
            {
                result.Add(f);
            }
        }
        return result;
    }

    static bool CheckIfAllElementsInString(string[] array, string searchString)
    {
        foreach (var item in array)
        {
            if (!searchString.Contains(item))
            {
                return false;
            }
        }
        return true;
    }

    public void RemoveFilm(Film film)
    {
        films.Remove(film);
        SaveLibraryToFile();
    }

    public void ClearLibrary()
    {
        films.Clear();
        SaveLibraryToFile();
    }
}