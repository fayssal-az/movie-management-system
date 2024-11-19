namespace movie_reservation_system;

public class MovieManagementTests
{
    [Fact]
    public void Given_a_movie_when_a_user_add_a_movie_then_the_movie_is_added()
    {
        Movie movie = new Movie();

        FakeMovieRepository fakeMovieRepository = new FakeMovieRepository();

        AddMovieUseCase addAMovieUC = new AddMovieUseCase();

        addAMovieUC.Execute(movie, fakeMovieRepository);

        Assert.NotEmpty(fakeMovieRepository.GetMovie(movie));

        Assert.Equal(1, fakeMovieRepository.GetMovie(movie).Count());

    }

}