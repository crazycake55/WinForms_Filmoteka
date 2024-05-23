using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class FilmLibrary
{
    public List<Film> films;
    public string filePath;

    /*������ �� ���� ���� �� ����� ���������� �� ������� ����� ��������� ��������
    ������ � ������ �������.*/
    public FilmLibrary(string path)
    {
        films = new List<Film>();
        filePath = path;
    }

    /*������ �� ���� ����� � ������� ����������� �� ���� ���� �� ������ ������ ������� ��������.*/
    public void AddFilm(Film film)
    {
        films.Add(film);
        SaveLibraryToFile();
    }

    /*������ ��� ��� ������ ������ � ����, ���� �� �������� �� ������ �������� �
    ��� �filePath�.*/
    public void SaveLibraryToFile()
    {
        string json = JsonSerializer.Serialize(films);
        File.WriteAllText(filePath, json);
    }

    /*��������, �� ���� ���� �� ������ � �filePath�, � ���� �� ���� � ��������� � �����
    ���������� ������ ������ ������ ������� ��������.*/
    public void LoadLibraryFromFile()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            films = JsonSerializer.Deserialize<List<Film>>(json);
        }
    }

    /*������ �� ���� ���������, ��
    ����� ������ ����� ������ � ��� �films�, ���� ����
    ������� ������ �������� ������.*/
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

    /*������� ��� ������ ������ ��� ��������� �Cast� �� �Location�.
    ������� ������ ��������.*/
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

    /*������� �������� ����� � ���� ��������.*/
    public void RemoveFilm(Film film)
    {
        films.Remove(film);
        SaveLibraryToFile();
    }

    /*������� �� ������ � ������� ��������.*/
    public void ClearLibrary()
    {
        films.Clear();
        SaveLibraryToFile();
    }
}