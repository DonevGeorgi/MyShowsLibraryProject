using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Forum posts")]
    public class Post
    {
        [Comment("Post Identitfier")]
        public int PostId { get; set; }
        [Required]
        [MaxLength(DataConstants.PostBodyMaxLength)]
        [Comment("Post text body")]
        public string PostBody { get; set; } = string.Empty;
        [Comment("Post creation date")]
        public DateTime CreatedOn { get; set; }
        [Required]
        [Comment("User Identitfier")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        public int TopicId { get; set; }
        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; } = null!;
        public IEnumerable<Reply> Replies { get; set; } = new List<Reply>();
    }
}
