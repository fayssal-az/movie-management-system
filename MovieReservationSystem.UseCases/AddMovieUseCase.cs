using MovieReservationSystem.Domain;

namespace MovieReservationSystem.UseCases
{
    public class AddMovieUseCase
    {

        private readonly IMovieRepository _movieRepository;

        

        public AddMovieUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Execute(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }
    }
}