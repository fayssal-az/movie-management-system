using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationSystem.Domain;

namespace MovieReservationSystem.Infrastructure
{
    public class MoviesDatastore
    {
        public List<MovieInDbDto> Movies { get; set; } = new List<MovieInDbDto>();

       
    }
}
