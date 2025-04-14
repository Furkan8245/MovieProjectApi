using MovieApi.Persistence.Context;
using MovieProjectApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProjectApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            if (value == null)
            {
                
                throw new Exception($"Movie with ID {command.MovieId} not found.");
            }

            value.Point = command.Point;
            value.Status = command.Status;
            value.Title = command.Title;
            value.ImageUrl = command.ImageUrl;
            value.Description = command.Description;
            value.Duration = command.Duration;
            value.ReleaseDate = command.ReleaseDate;
            value.ProductionYear = command.ProductionYear;

            await _context.SaveChangesAsync();
        }
    }
}
