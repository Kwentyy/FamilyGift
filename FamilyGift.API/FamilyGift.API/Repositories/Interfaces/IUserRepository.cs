using FamilyGift.API.Models.Entities;

namespace FamilyGift.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(User user);
    }
}
