namespace movie_reservation_system
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