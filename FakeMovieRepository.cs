using System.Collections;
using System.Collections.Immutable;

namespace movie_reservation_system
{
    public class FakeMovieRepository
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        internal void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        internal List<Movie> GetMovie(Guid id)
        {
            return Movies;
        }

        internal void UpdateMovie(Guid movieId, MovieDto movieDto)
        {
            Movie movieToUpdate = Movies.Where(movie => movie.Id == movieId).FirstOrDefault();
            movieToUpdate.Title = movieDto.Title;
        }
    }
}