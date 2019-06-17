using System.ComponentModel.DataAnnotations;

namespace Application.DataTransfer
{
    public class CompanyDto
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2,ErrorMessage = "Company name must have at least 2 characters!")]
        public string Name { get; set; }
    }
}