using System.Collections;

namespace movie_reservation_system
{
    internal class FakeMovieRepository
    {
        internal List<Movie> GetMovie(Movie movie)
        {
            return new List<Movie> {movie };
        }
    }
}