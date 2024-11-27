using MovieReservationSystem.Domain;
using MovieReservationSystem.Domain.Abstractions;
using MovieReservationSystem.Domain.DTOs;
namespace MovieReservationSystem.UseCases.Modules.MovieManagement
{
    public class EditMovieUseCase
    {
        private readonly IMovieRepository _movieRepository;

        public EditMovieUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void Execute(Guid movieId, EditMovieDto editMovieDto)
        {
            // Question : pourquoi faut écrire dans un DTO

            MovieInDbDto movieDto = _movieRepository.GetMovieById(movieId);

            // Question : la MAJ de l'objet domain n'implique pas la MAJ de la DB
            Movie movie = Movie.CreateMovieFromId(movieId, editMovieDto.Title, editMovieDto.PosterImageURL, editMovieDto.Description);


            _movieRepository.EditMovie(movieId, movie);
        }
    }
}