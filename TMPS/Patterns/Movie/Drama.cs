using Patterns.Visitor;

namespace Patterns.Movie
{
    public class Drama : IMovie
    {
        private string _name;
        private Genre.Genre _genre;
        private string _company;
        
        #region IMovie implementation
        
        public string Name { set => _name = value; }
        public Genre.Genre Genre { set => _genre = value; }
        public string Company { set => _company = value; }
        public int Views { get; set; }

        public string Description =>
            "Comedy movie:" + " " +
            "name = " + _name + ", " +
            "company = " + _company + ", " +
            "genre = " + _genre + ", " +
            "views = " + Views;

        #endregion
        
        #region IAcceptVisitor implementation

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion
    }
}