using System.Collections;
using System.Runtime.CompilerServices;

class Director : ICloneable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Director(string first, string last)
    {
        FirstName = first;
        LastName = last;
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public override string ToString()
    {
        return $"\tFirstName: {FirstName}\n\tLastName: {LastName}";
    }

}

enum Genre {comedy, horror, adventure, drama};
class Movie : ICloneable, IComparable<Movie>
{
    public string Title { get; set; }
    Director director;
    public string Country { get; set; }
    Genre genre;
    private int year;
    public int Year
    {
        set
        {
            if (value < 0)
                year = 0;
            else
                year = value;
        }
        get { return year; }
    }
    private short rating;
    public short Rating
    {
        set
        {
            if (value < 0)
                rating = 0;
            else
                rating = value;
        }
        get { return rating; }
    }
    public Movie(string title, string first, string last, string country, Genre gen, int year, short rating)
    {
        Title = title;
        director = new Director(first, last);
        Country = country;
        genre = gen;
        Year = year;
        Rating = rating;
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public int CompareTo(Movie? other)
    {
        return this.Rating.CompareTo(other.Rating);
    }
    public override string ToString()
    {
        return $"Title: {Title}\nDirector: \n{director.ToString()}\nCountry: {Country}\nGenre: {genre}\nYear: {Year}\nRating: {Rating}";
    }
}
class RatingComparer : IComparer<Movie>//IComparer
{
    //public int Compare(object? x, object? y)
    //{
    //    if (x is Student && y is Student) 
    //    {
    //        return (x as Student).LastName.CompareTo( (y as Student).LastName);
    //    }
    //    throw new NotImplementedException();    
    //}
    public int Compare(Movie? x, Movie? y)
    {
        return x!.Rating.CompareTo(y!.Rating);
    }
}
class YearComparer : IComparer<Movie>//IComparer
{
    public int Compare(Movie? x, Movie? y)
    {
        return x!.Year.CompareTo(y!.Year);
    }
}
class Cinema : IEnumerable
{
    Movie[] movies;
    public string Adress { get; set; }
    public Cinema(string adress, params Movie[] movie)
    {
        Adress = adress;
        movies = new Movie[movie.Length];
        for (int i = 0; i < movie.Length; i++)
        {
            movies[i] = movie[i];
        }
    }
    public void Print ()
    {
        Console.WriteLine("Adress: " + Adress);
        for (int i = 0; i < movies.Length; i++)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(movies[i].ToString());
        }
          Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
    }
    public IEnumerator GetEnumerator()
    {
        return movies.GetEnumerator();
    }
    public void Sort()
    {
        Array.Sort(movies);
    }
    public void Sort(IComparer<Movie> comparer)
    {
        Array.Sort(movies, comparer);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Director director = new Director("one", "two");
        Console.WriteLine(director.ToString());
        Movie movie = new Movie("Film", "Petya", "Petrov", "France", Genre.comedy, 2012, 5);
        Movie movie1 = new Movie("Film1", "Kolya", "Mykolay", "USA", Genre.drama, 2022, 3);
        Movie movie2 = new Movie("Film2", "Petya", "Petrov", "UK", Genre.comedy, 2013, 2);
        Movie movie3 = new Movie("Film3", "Pol", "Anderson", "USA", Genre.adventure, 2004, 4);
        Movie movie4 = new Movie("Film4", "Mykhailo","Dovshenko", "Ukraine", Genre.drama, 2020, 5);
        Movie movie5 = new Movie("Film5", "NO", "NAME", "USA", Genre.horror, 2020, 2);
        Console.WriteLine(movie.ToString());
        Console.WriteLine(movie.CompareTo(movie1));
        Cinema cinema = new Cinema("Shevchenko street, 123", movie, movie1, movie2, movie3, movie4, movie5);
        cinema.Print();
        Console.WriteLine("-------------- Sort by Rating-------------------");
        cinema.Sort(new RatingComparer());
        foreach (var film in cinema)
        {
            Console.WriteLine(film);
        }
        Console.WriteLine("-------------- Sort by Year-------------------");
        cinema.Sort(new YearComparer());
        foreach (var film in cinema)
        {
            Console.WriteLine(film);
        }
    }
}


