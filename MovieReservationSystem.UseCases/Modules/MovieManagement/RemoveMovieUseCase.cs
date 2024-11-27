using MovieReservationSystem.Domain.Abstractions;

namespace MovieReservationSystem.UseCases.Modules.MovieManagement
{
    public class RemoveMovieUseCase
    {
        private readonly IMovieRepository _movieRepository;

        public RemoveMovieUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Execute(Guid movieId)
        {
            _movieRepository.RemoveMovie(movieId);
        }
    }
}