using MovieApi.Persistence.Context;
using MovieProjectApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieProjectApi.Application.Features.CQRSDesignPattern.Results.CategoryResults;
using MovieProjectApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProjectApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.MovieId);
            return new GetMovieByIdQueryResult
            {
                ImageUrl = value.ImageUrl,
                Title = value.Title,
                Point = value.Point,
                Description = value.Description,
                Duration = value.Duration,
                ReleaseDate = value.ReleaseDate,
                ProductionYear = value.ProductionYear,
                Status = value.Status
            };
        
        }
    }
}
