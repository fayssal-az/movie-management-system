using System.Collections;
using System.Collections.Immutable;
using MovieReservationSystem.Domain;
using MovieReservationSystem.Domain.DTOs;

namespace MovieReservationSystem.Tests
{
    public class FakeMovieRepository : IMovieRepository
    {

        public List<Movie> Movies { get; set; } = new List<Movie>();

        public List<Movie> GetMovie(Guid id)
        {
            return Movies;
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void UpdateMovie(Guid movieId, MovieDto movieDto)
        {
            Movie movieToUpdate = Movies.Where(movie => movie.Id == movieId).FirstOrDefault();
            movieToUpdate.Title = movieDto.Title;
        }
    }
}