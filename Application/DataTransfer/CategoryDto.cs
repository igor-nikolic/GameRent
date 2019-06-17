using System.ComponentModel.DataAnnotations;

namespace Application.DataTransfer
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MinLength(3,ErrorMessage = "Category name must have at least 3 characters")]
        public string Name { get; set; }
    }
}