using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicBlogMVC.ViewModels.Article.Edit
{
    public class EditViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Display(Name = "Article Picture")]
        public IFormFile ArticlePicture { get; set; }
        public string ArticlePictureName { get; set; }

        public string GetArticlePictureName()
        {
            if (string.IsNullOrEmpty(ArticlePictureName)) return default;
            else return ArticlePictureName.Substring(ArticlePictureName.IndexOf("_") + 1);
        }
    }
}
