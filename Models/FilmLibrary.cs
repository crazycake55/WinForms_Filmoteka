using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class FilmLibrary
{
    public List<Film> films;
    public string filePath;

    /*отримує на вхід шлях до файла збереження та створює новий екземпляр бібліотеки
    фільмів з пустим списком.*/
    public FilmLibrary(string path)
    {
        films = new List<Film>();
        filePath = path;
    }

    /*отримує на вхід фільм з певними параметрами та додає його до списка фільмів поточної бібліотеки.*/
    public void AddFilm(Film film)
    {
        films.Add(film);
        SaveLibraryToFile();
    }

    /*зберігає дані про список фільмів у файл, який ми зберігаємо за шляхом вказаним у
    полі «filePath».*/
    public void SaveLibraryToFile()
    {
        string json = JsonSerializer.Serialize(films);
        File.WriteAllText(filePath, json);
    }

    /*перевіряє, чи існує файл за шляхом у «filePath», і якщо він існує – завантажує з нього
    збережений список фільмів замість поточної бібліотеки.*/
    public void LoadLibraryFromFile()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            films = JsonSerializer.Deserialize<List<Film>>(json);
        }
    }

    /*отримує на вхід параметри, за
    якими виконує пошук фільмів у полі «films», після чого
    повертає список потрібних фільмів.*/
    public List<Film> SearchFilms(string Title, string ReleaseYear, string Genre, string Director, string Location, double? Size, string Cast, string Studio, float? Rating)
    {

        var result = new List<Film>();
        foreach (var f in films)
        {
            if (f.Title.Contains(Title) && f.ReleaseYear.Contains(ReleaseYear) && f.Genres.Contains(Genre) 
                && CheckIfAllElementsInString(Location.Split(", "), f.Location) && f.Director.Contains(Director) && (f.Size >= Size || Size == null) 
                && CheckIfAllElementsInString(Cast.Split(", "), f.Cast) && f.Studio.Contains(Studio) && (f.Rating >= Rating || Rating == null))
            {
                result.Add(f);
            }
        }
        return result;
    }

    /*потрібен при пошуку фільмів для параметрів «Cast» та «Location».
    Повертає булеве значення.*/
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

    /*видаляє вказаний фільм з нашої бібліотеки.*/
    public void RemoveFilm(Film film)
    {
        films.Remove(film);
        SaveLibraryToFile();
    }

    /*видаляє всі фільми з поточної бібліотеки.*/
    public void ClearLibrary()
    {
        films.Clear();
        SaveLibraryToFile();
    }
}