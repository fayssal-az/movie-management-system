

using MovieReservationSystem.Domain.DTOs;

namespace MovieReservationSystem.Domain
{
    public interface IMovieRepository
    {
        public void AddMovie(Movie movie);
        public void UpdateMovie(Guid movieId, MovieDto movieDto);
    }
}