namespace MyShowsLibraryProject.Core.Models.ReviewModels
{
    public class ReviewInfoServiceModel
    {
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        public string Content {  get; set; } = string.Empty;
        public string UserUsername {  get; set; } = string.Empty;
        public string UserName {  get; set; } = string.Empty;
    }
}
