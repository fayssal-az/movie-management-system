
namespace MovieReservationSystem.Domain
{
    public class MovieInDbDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PosterImageUrl { get; set; }

        public MovieInDbDto(Guid id, string title, string description, string posterImageUrl )
        {
            Id = id;
            Title = title;
            Description = description;
            PosterImageUrl = posterImageUrl;
            
        }

        public MovieInDbDto()
        {
            
        }
    }
}
