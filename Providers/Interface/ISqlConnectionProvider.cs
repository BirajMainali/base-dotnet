using Npgsql;

namespace Base.Providers.Interface
{
    public interface ISqlConnectionProvider
    {
        NpgsqlConnection GetConnection();
    }
}