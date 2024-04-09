using RESTCheckliste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Creating instances of the Movie class
        var publisher1 = new Publisher { PublisherName  = "Warner Bros." };
        var publisher2 = new Publisher { PublisherName  = "Castle Rock Entertainment" };

        Movie movie1 = new Movie("Inception", 2010, publisher1);
        Movie movie2 = new Movie("The Shawshank Redemption", 1994, publisher2);

        // Displaying movie information
        Console.WriteLine("Movie 1:");
        movie1.DisplayMovieInfo();

        Console.WriteLine("\nMovie 2:");
        movie2.DisplayMovieInfo();
    }
}




























}

