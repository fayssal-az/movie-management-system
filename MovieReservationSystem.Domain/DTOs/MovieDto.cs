namespace MovieReservationSystem.Domain.DTOs
{
    public class MovieDto
    {
        public string Title { get; set; }
        public MovieDto(string title)
        {
            Title = title;
        }
    }
}