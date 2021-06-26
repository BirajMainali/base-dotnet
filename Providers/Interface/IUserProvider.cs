using System.Threading.Tasks;
using Base.Entities.User;

namespace Base.Providers.Interface
{
    public interface IUserProvider
    {
        Task<User> GetCurrentUser();
    }
}