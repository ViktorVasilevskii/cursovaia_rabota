using CreationalDesignPatterns.Iterator;
using Patterns.Movie;

namespace Patterns.Iterator
{
    public interface IIteratorCollection
    {
        IIterator<IMovie> Iterator();
    }
}