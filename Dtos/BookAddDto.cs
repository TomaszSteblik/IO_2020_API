using System;
using System.ComponentModel.DataAnnotations;

namespace api.DTOs
{
    public class BookAddDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImgUrl { get; set; }
    }
}