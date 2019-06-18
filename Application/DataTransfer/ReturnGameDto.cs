using System.ComponentModel.DataAnnotations;

namespace Application.DataTransfer
{
    public class ReturnGameDto
    {
        
        [Required(ErrorMessage = "GameId is required")]
        [Range(1, int.MaxValue, ErrorMessage = "GameId must be a positive number")]
        public int GameId { get; set; }
        
        [Required(ErrorMessage = "UserId of a game is required")]
        [Range(1, int.MaxValue, ErrorMessage = "UserId must be a positive number")]
        public int UserId { get; set; }
    }
}