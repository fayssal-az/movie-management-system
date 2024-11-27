using MovieReservationSystem.Domain;
using MovieReservationSystem.Domain.Abstractions;

namespace MovieReservationSystem.UseCases.Modules.MovieManagement
{
    public class AddMovieUseCase
    {

        private readonly IMovieRepository _movieRepository;



        public AddMovieUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Guid Execute(CreateMovieDto movie)
        {
            Movie newMovie = Movie.CreateMovie(movie.Title, movie.PosterImageURL, movie.Description);

            // Question : on peut supprimer ici _movieRepository.AddMovie(newMovie) ça n'empechera pas le test de 
            // passer

            _movieRepository.AddMovie(newMovie);

            return newMovie.GetId();
        }
    }
}