using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Interfaces;
using FloatDoor.Application.ViewModels;
using FloatDoor.Core.Entities;
using FloatDoor.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.Services.Implementations
{
    public class RatingService : IRatingService
    {
        private readonly FloatDoorDbContext _context;
        public RatingService(FloatDoorDbContext context)
        {
            _context = context;
        }

        public List<RatingsViewModel> GetAllRatings(string query)
        {
            var ratings = _context.Ratings;
            var ratingsVM = ratings.Select(r => new RatingsViewModel(r.Id, r.ValuationNote, r.Comment)).ToList();

            return ratingsVM;
        }

        public RatingDetailsViewModel GetRatingById(int id)
        {
            var rating = _context.Ratings.SingleOrDefault(r => r.Id == id);
            var ratingVM = new RatingDetailsViewModel(rating.Id, rating.ValuationNote, rating.Comment);

            return ratingVM;
        }

        public int CreateRating(CreateRatingInputModel inputModel)
        {
            var rating = new Rating(inputModel.ValuationNote, inputModel.Comment, inputModel.IdFloat, inputModel.IdCustomer);
            _context.Ratings.Add(rating);

            return rating.Id;
        }

        public void UpdateRating(UpdateRatingInputModel inputModel)
        {
            var rating = _context.Ratings.SingleOrDefault(r => r.Id == inputModel.Id);
            rating.Update(rating.ValuationNote, rating.Comment);
        }
    }
}
