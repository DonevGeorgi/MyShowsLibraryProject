using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Posts replies")]
    public class Reply
    {
        [Comment("Reply Identitfier")]
        public int ReplyId { get; set; }
        [Required]
        [MaxLength(DataConstants.ReplyBodyMaxLength)]
        [Comment("Reply text body")]
        public string ReplyBody { get; set; } = string.Empty;
        [Required]
        [Comment("User Identitfier")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        [Comment("Reply creation date")]
        public DateTime CreatedOn { get; set; }
    }
}
