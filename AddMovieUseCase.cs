
namespace movie_reservation_system
{
    public class AddMovieUseCase
    {
        private Movie movie { get; set; }
        private FakeMovieRepository fakeMovieRepository { get; set; }

        

        public AddMovieUseCase()
        {
           
        }

        internal void Execute(Movie movie, FakeMovieRepository fakeMovieRepository)
        {

        }
    }
}