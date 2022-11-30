using System;
using System.Collections.Generic;
using Patterns.Facade;
using Patterns.Movie;
using Patterns.Movie.Factory;
using Patterns.Movie.Genre;
using Patterns.Visitor;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseFactory upMovieFactory = new UPMovieFactory(); // UPMovieFactory.Instance;
            var upDrama = upMovieFactory.Create("Distant", Genre.Drama);
            var upFiction = upMovieFactory.Create("Jurassic Park", Genre.Fiction);
            var upComedy = upMovieFactory.Create("Abominable", Genre.Comedy);
            Console.WriteLine("Universal Pictures Factory:");
            Console.WriteLine(upDrama.Description);
            Console.WriteLine(upFiction.Description); 
            Console.WriteLine(upComedy.Description); 
            Console.WriteLine();

            IBaseFactory wbFactory = new WBMovieFactory(); // WBMovieFactory.Instance;;
            var wbDrama = wbFactory.Create("Creed", Genre.Drama);
            var wbFiction = wbFactory.Create("Interstellar", Genre.Fiction);
            var wbComedy = wbFactory.Create("Beetlejuice", Genre.Comedy);
            Console.WriteLine("Warner Bros Factory:");
            Console.WriteLine(wbDrama.Description);
            Console.WriteLine(wbFiction.Description); 
            Console.WriteLine(wbComedy.Description); 
            Console.WriteLine();

            IBaseFactory ironFactory = new CPMovieFactory(); // CPMovieFactory.Instance;
            var cpDrama = ironFactory.Create("Django Unchained", Genre.Drama);
            var cpFiction = ironFactory.Create("Venom", Genre.Fiction);
            var cpComedy = ironFactory.Create("Salt", Genre.Comedy);
            Console.WriteLine("Columbia Pictures:");
            Console.WriteLine(cpDrama.Description);
            Console.WriteLine(cpFiction.Description); 
            Console.WriteLine(cpComedy.Description);  
            Console.WriteLine();

            var cinema = new Cinema(); // Cinema.Instance;
            var movies = new IMovie[]
            {
                upDrama,
                upFiction,
                upComedy
            };
            cinema.Present(movies);
            Console.WriteLine();

            var customMovie = new CustomMovie(upMovieFactory);
            var wdComedy = customMovie.GetCustomMovie("Up!", "Victor Pictures.", Genre.Comedy);
            var msFiction = customMovie.GetCustomMovie("Avengers", "Marvel Studios.", Genre.Fiction);
            var ppDrama = customMovie.GetCustomMovie("Sonic", "Paramount Pictures.", Genre.Drama);
            Console.WriteLine(wdComedy.Description);
            Console.WriteLine(msFiction.Description);
            Console.WriteLine(ppDrama.Description);
            Console.WriteLine();
            
            cinema.Add(wbDrama);
            cinema.Add(cpComedy);
            cinema.Add(upFiction);
            
            cinema.Add(upMovieFactory.Create("Inception", Genre.Fiction));
            cinema.Add(upMovieFactory.Create("Joker", Genre.Drama));
            cinema.Add(upMovieFactory.Create("The Big Bang Theory", Genre.Comedy));
            cinema.Add(customMovie.GetCustomMovie("Kong", "Legendary Entertainment.", Genre.Fiction));

            var wbCompanyChanger = new WBCompanyChanger();
            wbCompanyChanger.Visit(cpDrama);
            cinema.Add(cpDrama);
            
            Console.WriteLine("Cinema contains: ");
            var iterator = cinema.Iterator();
            iterator.Reset();

            while (iterator.MoveNext())
            {
                var movie = iterator.Current;
                if (movie == null)
                    continue;
                
                Console.WriteLine(movie.Description);
            }
        }
    }
}