using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Implementations;
using FloatDoor.Application.ViewModels;
using System.Collections.Generic;

namespace FloatDoor.Application.Services.Interfaces
{
    public interface IRatingService
    {
        List<RatingsViewModel> GetAllRatings(string query);
        RatingDetailsViewModel GetRatingById(int id);
        int CreateRating(CreateRatingInputModel inputModel);
        void UpdateRating(UpdateRatingInputModel inputModel);
    }
}
