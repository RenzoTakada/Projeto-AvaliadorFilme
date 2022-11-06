using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace AvaliadorDeFilmes.Adapter.SQLAdapter.Models.Connection
{
    public class SQLDbContext
    {
        public IOptions<ConnectionString> _connectionString;


        public SQLDbContext(IOptions<ConnectionString> connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString.Value.GetConnectionString());
    }
}
