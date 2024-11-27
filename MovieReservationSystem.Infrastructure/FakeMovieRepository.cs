using System.Collections;
using System.Collections.Immutable;
using System.Linq;
using MovieReservationSystem.Domain;
using MovieReservationSystem.Domain.Abstractions;
using MovieReservationSystem.Domain.DTOs;

namespace MovieReservationSystem.Infrastructure
{
    public class FakeMovieRepository : IMovieRepository
    {

        public MoviesDatastore DataStore { get; set; } = new MoviesDatastore();

        public List<MovieInDbDto> GetMovie(Guid id)
        {
            return DataStore.Movies;
        }

        public void AddMovie(Movie movie)
        {
            MovieInDbDto movieInMemory = new MovieInDbDto();

            movieInMemory.Id = movie.GetId();
            movieInMemory.Title = movie.GetTitle();
            movieInMemory.Description = movie.GetDescription();

            DataStore.Movies.Add(movieInMemory);
        }
        
        public void RemoveMovie(Guid movieId)
        {
            DataStore.Movies.Remove(DataStore.Movies.FirstOrDefault(movie => movie.Id == movieId));
        }

        public MovieInDbDto GetMovieById(Guid movieId)
        {
            return DataStore.Movies.FirstOrDefault(movie => movie.Id == movieId);
        }

        public void EditMovie(Guid movieId, Movie movie)
        {
            DataStore.Movies.Remove(DataStore.Movies.FirstOrDefault(movie => movieId == movie.Id));

            var movieToWrite = new MovieInDbDto
            {
                Title = movie.GetTitle(),
                Description = movie.GetDescription(),
                Id = movieId,
                PosterImageUrl = movie.GetPosterImageUrl(),
            };

            DataStore.Movies.Add(movieToWrite);

        }

       
    }
}