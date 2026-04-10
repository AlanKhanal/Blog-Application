using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_Application.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Username name is required")]
        [MaxLength(100, ErrorMessage = "Username Name cannot exceed 100 characters")]
        public string UserName { get; set; }
        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }
        [Required]
        public string Content { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
