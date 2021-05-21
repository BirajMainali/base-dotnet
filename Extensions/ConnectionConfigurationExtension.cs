﻿using Microsoft.Extensions.Configuration;

namespace Base.Extensions
{
    public static class ConnectionConfigurationExtension
    {
        public static string GetDefaultConnectionString(this IConfiguration configuration)
        {
            return configuration.GetConnectionString("DefaultConnection");
        }
    }
}