namespace RESTCheckliste
{
    public interface IPublisher
    {
       public string PublisherName { get; set; }

    }


    public class Movie
    {
        //Properties
        public string Name { get; set; }
        public int Year { get; set; }
        public IPublisher Publisher { get; set; }

        //Constructor
        public Movie(string name, int year, IPublisher publisher)
        {
            Name= name;
            Year= year;
            Publisher = publisher;

        }

        //Methode til at vise (display) informaation omkring movie
        public void DisplayMovieInfo()
        {
            Console.WriteLine($"Movie:{Name}");
            Console.WriteLine($"Year:{Year}");
            Console.WriteLine($"Publisher:{Publisher}");

        }

    }
    public class Publisher : IPublisher
    {
        public string Name { get; set; }
       
    }



































































}