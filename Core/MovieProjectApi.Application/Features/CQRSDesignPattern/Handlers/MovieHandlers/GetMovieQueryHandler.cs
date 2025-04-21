using Microsoft.EntityFrameworkCore;
using MovieApi.Persistence.Context;
using MovieProjectApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProjectApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;
        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x => new GetMovieQueryResult
            {
                MovieId = x.MovieId,
                Title = x.Title,
                ImageUrl = x.ImageUrl,
                Point = x.Point,
                Description = x.Description,
                Duration = x.Duration,
                ReleaseDate = x.ReleaseDate,
                ProductionYear = x.ProductionYear,
                Status = x.Status
            }).ToList();
        }
    }
}
