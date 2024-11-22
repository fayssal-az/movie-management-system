using MovieReservationSystem.Domain;

namespace MovieReservationSystem.UseCases
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