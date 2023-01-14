using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicBlogMVC.Models.Entity
{
    [Table("Articles")]
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public string ArticlePicture { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        //Navigation props
        public virtual User Author { get; set; }
    }
}
