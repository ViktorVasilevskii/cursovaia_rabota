using System;
using System.Collections.Generic;
using CreationalDesignPatterns.Iterator;
using Patterns.Movie;

namespace Patterns.Iterator
{
    public class MovieIterator : IIterator<IMovie>
    {
        private List<IMovie> _movies;
        private int _index = -1;

        public MovieIterator(List<IMovie> movies)
        {
            _movies = movies;
        }
        
        public bool MoveNext()
        {
            return (++_index < _movies.Count);
        }

        public void Reset()
        {
            _index = -1;
        }

        public IMovie Current
        {
            get
            {
                try
                {
                    return _movies[_index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}