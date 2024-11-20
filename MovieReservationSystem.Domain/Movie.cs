namespace MovieReservationSystem.Domain
{
    public class Movie
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }

        public Movie(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
        }

    }
}