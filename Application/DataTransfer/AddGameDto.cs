using System.ComponentModel.DataAnnotations;

namespace Application.DataTransfer
{
    public class AddGameDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int CompanyId { get; set; }
    }
}