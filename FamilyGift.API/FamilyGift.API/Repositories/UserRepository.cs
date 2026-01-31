using FamilyGift.API.Data;
using FamilyGift.API.Models.Entities;
using FamilyGift.API.Repositories.Interfaces;

namespace FamilyGift.API.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly FamilyGiftContext _dbContext;
        public UserRepository(FamilyGiftContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddUser(User user)
        {
            var newUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = user.FirstName,
                LastName = user.LastName,
                CreatedAt = DateTime.UtcNow
            };
            await _dbContext.Users.AddAsync(user);

            await _dbContext.SaveChangesAsync();

        }
    }
}
