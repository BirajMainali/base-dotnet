using Base.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Base
{
    public static class EntityRegisterer
    {
        public static ModelBuilder AddBase(this ModelBuilder builder)
        {
            builder.Entity<User>();
            return builder;
        }
    }
}