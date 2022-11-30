using Patterns.Movie.Builder;

namespace Patterns.Movie.Factory
{
    public class WBMovieFactory : IBaseFactory
    {
        private BuilderDirector _director = new BuilderDirector();

        public IMovie Create(string name, Genre.Genre genre)
        {
            switch (genre)
            {
                case Genre.Genre.Drama:
                    var dramaBuilder = new DramaBuilder();
                    _director.MakeWBDrama(dramaBuilder, name);
                    return dramaBuilder.Get();
                case Genre.Genre.Fiction:
                    var fictionBuilder = new FictionBuilder();
                    _director.MakeWBFiction(fictionBuilder, name);
                    return fictionBuilder.Get();
                case Genre.Genre.Comedy:
                    var comedyBuilder = new ComedyBuilder();
                    _director.MakeWBComedy(comedyBuilder, name);
                    return comedyBuilder.Get();
                default:
                    return null;
            }
        }
    }
}