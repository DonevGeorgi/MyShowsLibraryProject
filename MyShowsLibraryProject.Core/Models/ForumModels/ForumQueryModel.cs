using MyShowsLibraryProject.Core.Models.BaseQueryModels;

namespace MyShowsLibraryProject.Core.Models.ForumModels
{
    public class ForumQueryModel : BaseQueryModel
    {
        public IEnumerable<TopicCardsInfoServiceModel> Topics { get; set; } = new List<TopicCardsInfoServiceModel>();
    }
}
