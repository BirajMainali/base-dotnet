using System;
using System.Threading.Tasks;
using Base.Entities.User;
using Base.Providers.Interface;
using Base.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Base.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly IUserRepository _userRepository;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<User> _userManager;

        public UserProvider(IUserRepository userRepository, IHttpContextAccessor contextAccessor,
            UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _contextAccessor = contextAccessor;
            _userManager = userManager;
        }

        public async Task<User> GetCurrentUser()
        {
            var userId = Convert.ToInt32(_userManager.GetUserId(_contextAccessor.HttpContext?.User));
            return await _userRepository.FindOrThrowAsync(userId);
        }
    }
}