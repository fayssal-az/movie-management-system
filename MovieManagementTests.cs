namespace movie_reservation_system;

public class MovieManagementTests
{
    [Fact]
    public void Given_a_movie_when_a_user_add_a_movie_then_the_movie_is_added()
    {
        Movie movie = new Movie("Pulp Fiction");

        FakeMovieRepository fakeMovieRepository = new FakeMovieRepository();

        AddMovieUseCase addAMovieUC = new AddMovieUseCase();

        addAMovieUC.Execute(movie, fakeMovieRepository);

        Assert.NotEmpty(fakeMovieRepository.GetMovie(movie.Id));

        Assert.Equal(movie.Id, fakeMovieRepository.GetMovie(movie.Id).FirstOrDefault().Id);

    }

    [Fact]
    public void Given_an_existing_movie_when_a_user_updates_the_movie_the_movie_is_updated()
    {
        Movie movie = new Movie("Pulp Fiction");

        FakeMovieRepository fakeMovieRepository = new FakeMovieRepository();

        fakeMovieRepository.Movies = new List<Movie> { movie };

        UpdateMovieUseCase updateMovieUC = new UpdateMovieUseCase();
        MovieDto updateMovieDto = new MovieDto("The Lord of the Rings");

        updateMovieUC.Execute(movie.Id, updateMovieDto, fakeMovieRepository);

        Assert.Equal("The Lord of the Rings", fakeMovieRepository
            .GetMovie(movie.Id)
            .FirstOrDefault()
            .Title);
        
    }
}