using System;
using System.Collections.Generic;

// Movie Class
class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    private int rating;

    public int Rating
    {
        get { return rating; }
        set
        {
            if (value >= 1 && value <= 10)
                rating = value;
            else
                rating = 5; // default value
        }
    }

    public Movie(string title, string genre, int year, int rating = 5)
    {
        Title = title;
        Genre = genre;
        Year = year;
        Rating = rating;
    }
}

// User Class
class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine($"Welcome {Name}!");
    }
}

// Review Class
class Review
{
    public string UserName { get; set; }
    public string MovieTitle { get; set; }
    public string Comment { get; set; }
    public int Rate { get; set; }

    public Review(string userName, string movieTitle, string comment, int rate)
    {
        UserName = userName;
        MovieTitle = movieTitle;
        Comment = comment;
        Rate = rate;
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Create Movies
        List<Movie> movies = new List<Movie>()
        {
            new Movie("Inception", "Sci-Fi", 2010, 9),
            new Movie("Titanic", "Romance", 1997, 8),
            new Movie("Avatar", "Action", 2009) // default rating
        };

        // Create User
        User user1 = new User("Ali", 25);

        // Display Movies
        Console.WriteLine("\nMovies:");
        foreach (var movie in movies)
        {
            Console.WriteLine($"{movie.Title} - {movie.Rating}");
        }

        // Add Review
        List<Review> reviews = new List<Review>()
        {
            new Review("Ali", "Inception", "Great movie!", 10)
        };

        // Display Reviews
        Console.WriteLine("\nReviews:");
        foreach (var review in reviews)
        {
            Console.WriteLine($"{review.UserName} rated {review.MovieTitle}: {review.Rate} - {review.Comment}");
        }
    }
}