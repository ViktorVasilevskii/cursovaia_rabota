namespace Patterns.Movie.Builder
{
    public class DramaBuilder : IMovieBuilder
    {
        private Drama _movie;

        public DramaBuilder()
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
            _movie = new Drama();
        }

        #endregion

        public Drama Get()
        {
            var movie = _movie;
            Reset();

            return movie;
        }
    }
}