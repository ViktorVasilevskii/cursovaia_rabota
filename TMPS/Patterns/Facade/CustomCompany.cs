using Patterns.Decorator;
using Patterns.Movie;
using Patterns.Movie.Factory;
using Patterns.Movie.Genre;

namespace Patterns.Facade
{
    public class CustomCompany : BaseMovieFactoryDecorator
    {
        private string _customCompany;
        
        public CustomCompany(string customCompany, IBaseFactory baseFactory) : base(baseFactory)
        {
            _customCompany = customCompany;
        }
        
        public override IMovie Create(string name, Genre genre)
        {
            var movie = base.Create(name, genre);
            movie.Company = _customCompany;
            return movie;
        }
    }
}