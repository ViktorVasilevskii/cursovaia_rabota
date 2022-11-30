namespace Patterns.Movie.Builder
{
    public class FictionBuilder : IMovieBuilder
    {
        private Fiction _movie;

        public FictionBuilder()
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
            set => _movie.Company = value;
        }

        public void Reset()
        {
            _movie = new Fiction();
        }

        #endregion

        public Fiction Get()
        {
            var movie = _movie;
            Reset();

            return movie;
        }
    }
}