namespace MyShowsLibraryProject.Core.Models.ForumModels
{
    public class ForumQueryServiceModel
    {
        public int TotalTopicCount { get; set; }
        public IEnumerable<TopicCardsInfoServiceModel> Topics { get; set; } = new List<TopicCardsInfoServiceModel>();
    }
}
