namespace Patterns.Movie.Genre
{
    public static class GenreExtension
    {
        public static string ToString(this Genre genre)
        {
            switch(genre)
            {
                case Genre.Comedy:
                    return "Comedy";
                case Genre.Fiction:
                    return "Fiction";
                case Genre.Drama:
                    return "Drama";
                default:
                    return "WARNING: IMPLEMENT ME";
            }
        }
    }
}