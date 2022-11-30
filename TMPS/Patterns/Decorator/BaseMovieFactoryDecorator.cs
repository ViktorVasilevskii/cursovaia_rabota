using Patterns.Movie;
using Patterns.Movie.Factory;
using Patterns.Movie.Genre;

namespace Patterns.Decorator
{
    public class BaseMovieFactoryDecorator : IBaseFactory
    {
        protected IBaseFactory _wrapper;

        public BaseMovieFactoryDecorator(IBaseFactory baseFactory)
        {
            _wrapper = baseFactory;
        }

        public virtual IMovie Create(string name, Genre genre)
        {
            var movie = _wrapper.Create(name, genre);
            movie.Views += 1000;

            return movie;
        }
    }
}