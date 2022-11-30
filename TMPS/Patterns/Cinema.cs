using System;
using System.Collections.Generic;
using CreationalDesignPatterns.Iterator;
using Patterns.Iterator;
using Patterns.Movie;

namespace Patterns
{
    public class Cinema : IIteratorCollection
    {
        private List<IMovie> _movies = new List<IMovie>();

        public void Present(IMovie[] movies)
        {
            Console.WriteLine("Cinema contains following movies");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Description);
            }
        }

        public void Add(IMovie movie)
        {
            _movies.Add(movie);
        }

        public List<IMovie> Get()
        {
            return _movies;
        }
        
        #region IIteratorCollection implementation

        public IIterator<IMovie> Iterator()
        {
            return new MovieIterator(_movies);
        }

        #endregion
    }
}