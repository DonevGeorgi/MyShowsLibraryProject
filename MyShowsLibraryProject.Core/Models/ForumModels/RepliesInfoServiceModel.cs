namespace MyShowsLibraryProject.Core.Models.ForumModels
{
    public class RepliesInfoServiceModel
    {
        public int ReplyId { get; set; }
        public string ReplyBody { get; set; } = string.Empty;
        public string CreatedOn { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
    }
}
