using MovieReservationSystem.Domain;
using MovieReservationSystem.Domain.DTOs;
namespace MovieReservationSystem.UseCases
{
    public class UpdateMovieUseCase
    {
        private readonly IMovieRepository _movieRepository;

        public UpdateMovieUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void Execute(Guid movieId, MovieDto updateMovieDto)
        {
            _movieRepository.UpdateMovie(movieId, updateMovieDto);
        }
    }
}