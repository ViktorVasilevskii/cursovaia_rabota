using Patterns.Visitor;

namespace Patterns.Movie
{
    public interface IMovie : IAcceptVisitor
    {
        string Name { set; }
        Genre.Genre Genre { set; }
        string Company { set; }
        int Views { get; set; }
        string Description { get; }
    }
}