
namespace movie_reservation_system
{
    public class UpdateMovieUseCase
    {
        internal void Execute(Guid movieId, MovieDto updateMovieDto, FakeMovieRepository fakeMovieRepository)
        {            
            fakeMovieRepository.UpdateMovie(movieId, updateMovieDto);
        }
    }
}