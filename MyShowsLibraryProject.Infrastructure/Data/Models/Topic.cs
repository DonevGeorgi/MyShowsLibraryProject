using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Forum topics")]
    public class Topic
    {
        [Comment("Topic Identitfier")]
        public int TopicId { get; set; }
        [Required]
        [MaxLength(DataConstants.TopicNameMaxLength)]
        [Comment("Topic name")]
        public string Name { get; set; } = string.Empty;
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
    }
}
