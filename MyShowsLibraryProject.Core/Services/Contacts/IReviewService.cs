using MyShowsLibraryProject.Core.Models.ReviewModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IReviewService
    {
        Task<int> CreateAsync(ReviewFormModel review, string userId,int showId,string showType);
    }
}
