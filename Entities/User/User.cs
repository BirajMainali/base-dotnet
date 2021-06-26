using Base.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Base.Entities.User
{
    public class User : IdentityUser, ISoftDelete
    {
        public string ResetToken { get; set; }
    }
}