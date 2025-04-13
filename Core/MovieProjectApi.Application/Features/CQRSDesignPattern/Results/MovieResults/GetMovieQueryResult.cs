using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProjectApi.Application.Features.CQRSDesignPattern.Results.MovieResults
{
    public class GetMovieQueryResult
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public decimal Point { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ProductionYear { get; set; }
        public bool Status { get; set; }
    }
}
