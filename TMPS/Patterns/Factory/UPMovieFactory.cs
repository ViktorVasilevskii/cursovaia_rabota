using Patterns.Movie.Builder;

namespace Patterns.Movie.Factory
{
    public class UPMovieFactory : IBaseFactory
    {
        private BuilderDirector _director = new BuilderDirector();

        public IMovie Create(string name, Genre.Genre genre)
        {
            switch (genre)
            {
                case Genre.Genre.Drama:
                    var dramaBuilder = new DramaBuilder();
                    _director.MakeUPDrama(dramaBuilder, name);
                    return dramaBuilder.Get();
                case Genre.Genre.Fiction:
                    var fictionBuilder = new FictionBuilder();
                    _director.MakeUPFiction(fictionBuilder, name);
                    return fictionBuilder.Get();
                case Genre.Genre.Comedy:
                    var comedyBuilder = new ComedyBuilder();
                    _director.MakeUPComedy(comedyBuilder, name);
                    return comedyBuilder.Get();
                default:
                    return null;
            }
        }
    }
}