namespace MovieReservationSystem.Domain.DTOs
{
    public class EditMovieDto
    {
        public string Description { get; set; }
        public string PosterImageURL { get; set; }
        public string Title { get; set; }

        public EditMovieDto(string title, string posterURL, string description)
        {
            Description = description;
            PosterImageURL = posterURL;
            Title = title;
        }

    }
}