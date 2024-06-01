namespace MyShowsLibraryProject.Core.Models.ForumModels
{
    public class AllPostInfoServiceModel
    {
        public IEnumerable<PostsInfoServiceModel> Posts { get; set; } = new List<PostsInfoServiceModel>();
    }
}
