using Patterns.Movie;

namespace Patterns.Visitor
{
    public class WBCompanyChanger : IVisitor
    {
        #region IVisitor implementation

        public void Visit(IMovie movie)
        {
            movie.Company = "Warner Bros.";
        }

        #endregion
    }
}