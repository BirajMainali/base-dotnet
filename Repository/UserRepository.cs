using Base.BaseRepository;
using Base.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Base.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}