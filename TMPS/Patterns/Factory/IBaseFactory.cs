namespace Patterns.Movie.Factory
{
    public interface IBaseFactory
    {
        IMovie Create(string name, Genre.Genre genre);
    }
}