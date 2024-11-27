using MovieReservationSystem.Domain.Types;

namespace MovieReservationSystem.Domain
{
    public class Movie
    {
        private Guid Id { get; set; }
        private string Title { get; set; }
        private string PosterImageURL { get; set; }
        private string Description { get; set; }
        private IEnumerable<Showtime> Showtimes { get; set; }
        private Genre Genre { get; set; }

        private Movie(string title, string posterImageURL, string description)
        {
            Id = Guid.NewGuid();
            Title = title;
            PosterImageURL = posterImageURL;
            Description = description;
        }

        private Movie(Guid id, string title, string posterImageURL, string description)
        {
           
            Title = title;
            PosterImageURL = posterImageURL;
            Description = description;
        }

        public static Movie CreateMovie(string title, string posterImageURL, string description)
        {
            return new Movie(title, posterImageURL, description)
            {
                Title = title,
                PosterImageURL = posterImageURL,
                Description = description

            };
        }

        public static Movie CreateMovieFromId(Guid id, string title, string posterImageURL, string description)
        {
            return new Movie(id, title, posterImageURL, description)
            {
                Id = id,
                Title = title,
                PosterImageURL = posterImageURL,
                Description = description

            };
        }

        public Guid GetId() { return Id; }
        public string GetTitle() { return Title; }
        public string GetPosterImageUrl()
        {
           return this.PosterImageURL;
        }

        public string GetDescription()
        {
            return this.Description;
        }

  

        public void EditMovie(string title, string posterImageURL, string description)
        {
            Title = title;
            Description = description;
            PosterImageURL = posterImageURL;
        }

        
    }
}