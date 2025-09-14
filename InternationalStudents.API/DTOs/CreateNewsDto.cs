using System.ComponentModel.DataAnnotations;

namespace InternationalStudents.API.DTOs
{
    public class CreateNewsDto
    {
        [Required(ErrorMessage = "Title is required")]
        [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Content is required")]
        [StringLength(10000, ErrorMessage = "Content cannot exceed 10000 characters")]
        public string Content { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Summary cannot exceed 500 characters")]
        public string? Summary { get; set; }

        [StringLength(50, ErrorMessage = "Category cannot exceed 50 characters")]
        public string? Category { get; set; }

        public List<string>? Tags { get; set; }

        public List<string>? Images { get; set; }

        public string? AuthorId { get; set; }

        [StringLength(100, ErrorMessage = "Author name cannot exceed 100 characters")]
        public string? AuthorName { get; set; }

        public bool? IsPublished { get; set; } = false;
    }
}