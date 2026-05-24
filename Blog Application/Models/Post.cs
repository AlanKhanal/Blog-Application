using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_Application.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Insert Title")]
        [MaxLength(400,ErrorMessage ="Character Limit exceeded. 400 characters only.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Please Insert Content")]
        public string Content { get; set; }

        [Required(ErrorMessage ="Please Insert Author")]
        [MaxLength(100, ErrorMessage = "Character Limit exceeded. 100 characters only.")]
        public string Author { get; set; }
        [ValidateNever]
        public string FeatureImagePath { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }= DateTime.Now;

        [ForeignKey("Category")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
