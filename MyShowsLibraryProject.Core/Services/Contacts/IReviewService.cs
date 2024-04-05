using MyShowsLibraryProject.Core.Models.ReviewModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IReviewService
    {
        Task<ReviewInfoServiceModel> GetReviewById(int reviewId);
        Task<int> CreateAsync(ReviewFormModel review, string userId,int showId,string showType);
        Task EditAsync(int reviewId,ReviewFormModel review);
        Task DeleteAsync(int reviewId, string userId);
    }
}
