namespace Patterns.Movie.Builder
{
    public class BuilderDirector
    {
        public IMovieBuilder MakeCPFiction(FictionBuilder builder, string name)
        {
            builder.Reset();
            builder.Name = name;
            builder.Genre = Genre.Genre.Fiction;
            builder.Company = "Columbia Pictures.";

            return builder;
        }
        
        public IMovieBuilder MakeCPDrama(DramaBuilder builder, string name)
        {
            builder.Reset();
            builder.Name = name;
            builder.Genre = Genre.Genre.Drama;
            builder.Company = "Columbia Pictures.";

            return builder;
        }
        
        public IMovieBuilder MakeCPComedy(ComedyBuilder builder, string name)
        {
            builder.Reset();
            builder.Name = name;
            builder.Genre = Genre.Genre.Comedy;
            builder.Company = "Columbia Pictures.";

            return builder;
        } 
        
        public IMovieBuilder MakeWBFiction(FictionBuilder builder, string name)
        {
            builder.Reset();
            builder.Name = name;
            builder.Genre = Genre.Genre.Fiction;
            builder.Company = "Warner Bros.";

            return builder;
        }
        
        public IMovieBuilder MakeWBDrama(DramaBuilder builder, string name)
        {
            builder.Reset();
            builder.Name = name;
            builder.Genre = Genre.Genre.Drama;
            builder.Company = "Warner Bros.";

            return builder;
        }
        
        public IMovieBuilder MakeWBComedy(ComedyBuilder builder, string name)
        {
            builder.Reset();
            builder.Name = name;
            builder.Genre = Genre.Genre.Comedy;
            builder.Company = "Warner Bros.";

            return builder;
        }

        public IMovieBuilder MakeUPFiction(FictionBuilder builder, string name)
        {
            builder.Reset();
            builder.Name = name;
            builder.Genre = Genre.Genre.Fiction;
            builder.Company = "Universal Pictures.";

            return builder;
        }

        public IMovieBuilder MakeUPDrama(DramaBuilder builder, string name)
        {
            builder.Reset();
            builder.Name = name;
            builder.Genre = Genre.Genre.Drama;
            builder.Company = "Universal Pictures.";

            return builder;
        }
        
        public IMovieBuilder MakeUPComedy(ComedyBuilder builder,string name)
        {
            builder.Reset();
            builder.Name = "Farberware";
            builder.Genre = Genre.Genre.Drama;
            builder.Company = "Universal Pictures.";

            return builder;
        }
    }
}