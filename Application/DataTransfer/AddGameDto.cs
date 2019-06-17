using System.ComponentModel.DataAnnotations;

namespace Application.DataTransfer
{
    public class AddGameDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required(ErrorMessage = "CategoryId is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "CategoryId must be a positive number")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "CompanyId is Required")]
        [Range(1, int.MaxValue, ErrorMessage = "CompanyId must be a positive number")]
        public int CompanyId { get; set; }
    }
}