using Patterns.Movie;

namespace Patterns.Visitor
{
    public interface IVisitor
    {
        void Visit(IMovie movie);
    }
}