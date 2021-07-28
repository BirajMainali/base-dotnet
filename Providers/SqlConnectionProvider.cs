using Base.Extensions;
using Base.Providers.Interface;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Base.Providers
{
    public class SqlConnectionProvider : ISqlConnectionProvider
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionProvider(IConfiguration configuration)
            => _configuration = configuration;

        /// <summary>
        /// Get Postgres Sql Connection string
        /// </summary>
        /// <returns></returns>
        public NpgsqlConnection GetConnection()
        {
            var connectionString = _configuration.GetDefaultConnectionString();
            return new NpgsqlConnection(connectionString);
        }
    }
}