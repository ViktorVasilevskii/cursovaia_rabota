namespace Patterns.Movie.Builder
{
    public interface IMovieBuilder
    {
        string Name { set; }
        Genre.Genre Genre { set; }
        string Company { set; }

        void Reset();
    }
}