namespace FamilyGift.API.Models.Dtos.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
