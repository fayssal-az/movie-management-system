using MovieReservationSystem.Domain;
using MovieReservationSystem.Domain.DTOs;
using MovieReservationSystem.UseCases;
using MovieReservationSystem.UseCases.Modules.MovieManagement;
using MovieReservationSystem.Infrastructure;


namespace MovieReservationSystem.Tests;
public class MovieManagementTests
{
    public Movie _movie;
    private readonly FakeMovieRepository _fakeMovieRepository;

    public MovieManagementTests()
    {
        _movie = Movie.CreateMovie("Pulp Fiction", "pulp.png", "Best film ever");
        _fakeMovieRepository = new FakeMovieRepository();
    }

    [Fact]
    public void When_a_user_adds_a_movie_to_an_empty_store_Then_the_movie_is_added()
    {

        AddMovieUseCase addAMovieUC = new AddMovieUseCase(_fakeMovieRepository);

        CreateMovieDto movieDto = new CreateMovieDto()
        {
            Title = "Pulp Fiction",
            Description = "Best film ever",
            PosterImageURL = "pulp.png",
        };

        Guid movieId = addAMovieUC.Execute(movieDto);

        // Question : how check that the Db is called ? Shold we check here ?

        Assert.NotNull(_fakeMovieRepository.GetMovieById(movieId));

    }

    [Fact]
    public void When_a_user_edits_a_movie_Then_the_movie_is_updated()
    {

        _fakeMovieRepository.AddMovie(_movie);

        EditMovieUseCase editMovieUc = new EditMovieUseCase(_fakeMovieRepository);

        EditMovieDto editMovieDto = new EditMovieDto("The Lord of the Rings", "url", "description");

        editMovieUc.Execute(_movie.GetId(), editMovieDto);

        // Question : how check that the Db is called ? Shold we check here ?


        Assert.Equal("The Lord of the Rings", _fakeMovieRepository.GetMovieById(_movie.GetId()).Title);

        Assert.Equal("url", _fakeMovieRepository.GetMovieById(_movie.GetId()).PosterImageUrl);

        Assert.Equal("description", _fakeMovieRepository.GetMovieById(_movie.GetId()).Description);
    }

    [Fact]
    public void When_a_user_removes_the_movie_then_the_movie_is_removed()
    {

        _fakeMovieRepository.AddMovie(_movie);

        RemoveMovieUseCase removeMovieUC = new RemoveMovieUseCase(_fakeMovieRepository);

        removeMovieUC.Execute(_movie.GetId());

        Assert.Empty(_fakeMovieRepository.DataStore.Movies);

    }

    [Fact]
    public void Given_a_movie_When_a_user_removes_the_movie_And_the_movie_is_not_found_then_an_error_is_raised()
    {


        RemoveMovieUseCase removeMovie = new RemoveMovieUseCase(_fakeMovieRepository);

        Assert.Throws<Exception>(() => removeMovie.Execute(_movie.GetId()));

    }

}

