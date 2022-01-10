using System;
using System.Collections.Generic;
using System.Linq;


internal class MovieDatabase
{
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>();
        movies.Add(new Movie() { Title = "A Nightmare on Elm Street", Category = "Horror" });
        movies.Add(new Movie() { Title = "A League of Their Own", Category = "Comedy" });
        movies.Add(new Movie() { Title = "Angels in the Outfield", Category = "Sci-fi" });
        movies.Add(new Movie() { Title = "A Cool, Dry Place", Category = "Drama" });
        movies.Add(new Movie() { Title = "Toy Story", Category = "Animation" });
        movies.Add(new Movie() { Title = "Moana", Category = "Animation" });
        movies.Add(new Movie() { Title = "Almost Famous", Category = "Drama" });
        movies.Add(new Movie() { Title = "American Psycho", Category = "Drama" });
        movies.Add(new Movie() { Title = "Ali", Category = "Drama" });
        movies.Add(new Movie() { Title = "A Beautiful Mind", Category = "Drama" });
        movies.Add(new Movie() { Title = "Interstellar", Category = "Sci-fi" });
        movies.Add(new Movie() { Title = "Agent Cody Banks", Category = "Sci-fi" });

    
        
        static UserQuery(string userquery1)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in this list.");
            Console.WriteLine("What category are you interested in?");
            userquery1 = Console.ReadLine();

        }

        foreach (Movie in Movies)
      

    }

   
}



