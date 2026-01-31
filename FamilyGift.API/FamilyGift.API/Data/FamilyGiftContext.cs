using FamilyGift.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FamilyGift.API.Data
{
    public class FamilyGiftContext: DbContext
    {
        public FamilyGiftContext(DbContextOptions<FamilyGiftContext> dbContextOptions): base(dbContextOptions)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
