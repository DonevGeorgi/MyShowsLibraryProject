namespace MyShowsLibraryProject.Core.Models.ForumModels
{
    public class PostsInfoServiceModel
    {
        public int PostId { get; set; }
        public string PostBody { get; set; } = string.Empty;
        public string CreatedOn { get; set; } = string.Empty;
        public string UserUsername { get; set; } = string.Empty;
        public List<RepliesInfoServiceModel> Replies { get; set; } = new List<RepliesInfoServiceModel>();
    }
}
