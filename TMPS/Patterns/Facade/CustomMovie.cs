using Patterns.Movie;
using Patterns.Movie.Factory;
using Patterns.Movie.Genre;

namespace Patterns.Facade
{
    public class CustomMovie
    {
        private IBaseFactory _baseFactory;

        public CustomMovie(IBaseFactory baseFactory)
        {
            _baseFactory = baseFactory;
        }

        public IMovie GetCustomMovie(string name, string company, Genre genre)
        {
            IBaseFactory factory = new CustomCompany(company, _baseFactory);
            var customMovie = factory.Create(name, genre);
            return customMovie;
        }
    }
}