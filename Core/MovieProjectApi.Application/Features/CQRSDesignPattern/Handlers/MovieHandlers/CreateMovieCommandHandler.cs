using MovieApi.Persistence.Context;
using MovieProjectApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieProjectApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProjectApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        public MovieContext _context;

        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                ImageUrl = command.ImageUrl,
                ProductionYear = command.ProductionYear,
                Description = command.Description,
                Duration = command.Duration,
                Point = command.Point,
                ReleaseDate = command.ReleaseDate,
                Status = command.Status,
                Title = command.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
