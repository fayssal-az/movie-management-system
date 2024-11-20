using MovieReservationSystem.Domain;
using MovieReservationSystem.UseCases;
using MovieReservationSystem.Domain.DTOs;

namespace MovieReservationSystem.Tests;
public class MovieManagementTests
{
    public Movie _movie;
    private readonly FakeMovieRepository _fakeMovieRepository;

    public MovieManagementTests()
    {
        _movie = new Movie("Pulp Fiction");
        _fakeMovieRepository = new FakeMovieRepository();
    }

    [Fact]
    public void Given_a_movie_when_a_user_add_a_movie_then_the_movie_is_added()
    {

        AddMovieUseCase addAMovieUC = new AddMovieUseCase(_fakeMovieRepository);

        addAMovieUC.Execute(_movie);

        Assert.NotEmpty(_fakeMovieRepository.GetMovie(_movie.Id));

        Assert.Equal(_movie.Id, _fakeMovieRepository.GetMovie(_movie.Id).FirstOrDefault().Id);

    }

    [Fact]
    public void Given_an_existing_movie_when_a_user_updates_the_movie_the_movie_is_updated()
    {

        _fakeMovieRepository.Movies = new List<Movie> { _movie };

        UpdateMovieUseCase updateMovieUC = new UpdateMovieUseCase(_fakeMovieRepository);

        MovieDto updateMovieDto = new MovieDto("The Lord of the Rings");

        updateMovieUC.Execute(_movie.Id, updateMovieDto);

        Assert.Equal("The Lord of the Rings", _fakeMovieRepository
            .GetMovie(_movie.Id)
            .FirstOrDefault()
            .Title);

    }

}

