using MovieReservationSystem.Domain.DTOs;

namespace MovieReservationSystem.Domain.Abstractions
{
    public interface IMovieRepository
    {
        public void AddMovie(Movie movie);
        MovieInDbDto GetMovieById(Guid movieId);
        public void RemoveMovie(Guid movieId);
        public void EditMovie(Guid movieId, Movie movie);
    }
}