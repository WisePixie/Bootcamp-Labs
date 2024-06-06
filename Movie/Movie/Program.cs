

namespace MovieApp
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}




namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Toy Story", "animated"),
                new Movie("The Lion King", "animated"),
                new Movie("Inception", "scifi"),
                new Movie("The Dark Knight", "drama"),
                new Movie("Pulp Fiction", "drama"),
                new Movie("Get Out", "horror"),
                new Movie("A Quiet Place", "horror"),
                new Movie("Interstellar", "scifi"),
                new Movie("Finding Nemo", "animated"),
                new Movie("The Shawshank Redemption", "drama")
            };

            bool continueLoop = true;

            while (continueLoop)
            {
                Console.WriteLine("Enter a category to display movies (animated, drama, horror, scifi):");
                string inputCategory = Console.ReadLine().ToLower();

                if (inputCategory == "animated" || inputCategory == "drama" || inputCategory == "horror" || inputCategory == "scifi")
                {
                    Console.WriteLine($"Movies in the {inputCategory} category:");
                    foreach (Movie movie in movies)
                    {
                        if (movie.Category == inputCategory)
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid category. Please enter one of the following: animated, drama, horror, scifi.");
                }

                Console.WriteLine("Do you want to continue? (yes/no):");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "yes")
                {
                    continueLoop = false;
                }
            }
        }
    }
}














/*using System;

Console.WriteLine("")


List<Movie> movies = new List<Movie>
            {
                new Movie("Toy Story", "animated"),
                new Movie("The Lion King", "animated"),
                new Movie("Inception", "scifi"),
                new Movie("The Dark Knight", "drama"),
                new Movie("Pulp Fiction", "drama"),
                new Movie("Get Out", "horror"),
                new Movie("A Quiet Place", "horror"),
                new Movie("Interstellar", "scifi"),
                new Movie("Finding Nemo", "animated"),
                new Movie("The Shawshank Redemption", "drama")
            };

internal class Movie
{
    private string v1;
    private string v2;

    public Movie(string v1, string v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }
}

bool continueLoop = true;

while (continueLoop)
{
    Console.WriteLine("Enter a category to display movies (animated, drama, horror, scifi):");
    string inputCategory = Console.ReadLine().ToLower();

    if (inputCategory == "animated" || inputCategory == "drama" || inputCategory == "horror" || inputCategory == "scifi")
    {
        Console.WriteLine($"Movies in the {inputCategory} category:");
        foreach (Movie movie in movies)
        {
            if (movie.Category == inputCategory)
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid category. Please enter one of the following: animated, drama, horror, scifi.");
    }

    Console.WriteLine("Do you want to continue? (yes/no):");
    string continueInput = Console.ReadLine().ToLower();
    if (continueInput != "yes")
    {
        continueLoop = false;
    }
}
        }
*/