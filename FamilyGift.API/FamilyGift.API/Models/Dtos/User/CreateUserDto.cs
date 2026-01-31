using System.ComponentModel.DataAnnotations;

namespace FamilyGift.API.Models.Dtos.User
{
    public class CreateUserDto
    {
        [Required]
        [MaxLength(100)]
        public required string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public required string LastName { get; set; }
    }
}
