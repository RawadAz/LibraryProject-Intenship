using Dapper;
using Library.Data;
using Library.Models.Employee;
using Library.Repositories.GenericRepo;
using LiteDB;

namespace Library.Repositories.EmployeeRepo
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private new readonly LibraryDBConnection _Connection;

        public IGenericRepository<Employee> GenericRepository { get; private set; }

        public EmployeeRepository(LibraryDBConnection Connection) : base(Connection)
        {
            _Connection = Connection;
            GenericRepository = new GenericRepository<Employee>(_Connection);
        }

        public async Task<int> ChangePasswordAsync(string getPassQuery,string updatePassQuery ,string old_password)
        {

            using (var connection = _Connection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var existingPassword = await connection.QueryFirstOrDefaultAsync<string>(getPassQuery, transaction: transaction);
                        
                        if (existingPassword == null)
                            return 3;
                       
                        if (!existingPassword.Equals(Hashing.ToSHA256(old_password.ToLower())))
                            return 4;
                        
                        var QueryResult = await connection.ExecuteAsync(updatePassQuery, transaction: transaction);

                        transaction.Commit();
                        connection.Close();
                        return QueryResult;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        connection.Close();
                        throw;
                    }
                }
            }
        }

        public async Task<LoginInfoDTO> GetLoginInfoAsync(string query)
        {
            using (var connection = _Connection.GetConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<LoginInfoDTO>(query);  
            }
        }

        public async Task<IEnumerable<int>> GetIdsAsync(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<int>(query)).ToList();
        }
    }
}
