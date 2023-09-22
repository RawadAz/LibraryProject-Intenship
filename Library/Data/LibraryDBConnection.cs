using Microsoft.Data.SqlClient;
using System.Data;

namespace Library.Data
{
    public class LibraryDBConnection
    {
        private readonly string _ConnectionString;
        private readonly Lazy<IDbConnection> _Connection;
        
        public LibraryDBConnection(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
            _Connection = new Lazy<IDbConnection>(() => new SqlConnection(_ConnectionString));
        }
        public IDbConnection GetConnection() => _Connection.Value;

    }
}
