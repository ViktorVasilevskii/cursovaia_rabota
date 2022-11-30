namespace Patterns.Movie.Builder
{
    public class ComedyBuilder : IMovieBuilder
    {
        private Comedy _movie;

        public ComedyBuilder()
        {
            Reset();
        }

        #region IMovieBuilder implementation

        public string Name
        {
            set => _movie.Name = value;
        }

        public Genre.Genre Genre
        {
            set => _movie.Genre = value;
        }

        public string Company
        {
            set => _movie.Company  = value;
        }

        public void Reset()
        {
            _movie = new Comedy();
        }

        #endregion

        public Comedy Get()
        {
            var movie = _movie;
            Reset();

            return movie;
        }
    }
}