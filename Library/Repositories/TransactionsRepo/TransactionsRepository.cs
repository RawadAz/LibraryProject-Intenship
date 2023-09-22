using Dapper;
using Library.Data;
using Library.Models.Branch;
using Library.Models.Transactions.DTO_s;
using Library.Repositories.GenericRepo;

namespace Library.Repositories.TransactionsRepo
{
    public class TransactionsRepository : GenericRepository<TransactionsDTO>, ITransactionsRepository
    {
        private new readonly LibraryDBConnection _Connection;

        public IGenericRepository<TransactionsDTO> GenericRepository { get; private set;}

        public TransactionsRepository(LibraryDBConnection connection): base(connection)
        {
            _Connection = connection;
            GenericRepository = new GenericRepository<TransactionsDTO>(_Connection);

        }

        public async Task<List<EmployeeSalesDTO>> getAllEmployeeSales(string query)
        {
            using (var connection = _Connection.GetConnection())
            {
                return (await connection.QueryAsync<EmployeeSalesDTO>(query)).ToList();
            }
        }

        public async Task<List<TopSellingBookDTO>> getTopSellingBooks(string query)
        {
            using (var connection = _Connection.GetConnection())
            {
                return (await connection.QueryAsync<TopSellingBookDTO>(query)).ToList();
            }
        }

        public async Task<List<BookReturnDTO>> getBookReturnDates(string query)
        {
            using (var connection = _Connection.GetConnection())
            {
                return (await connection.QueryAsync<BookReturnDTO>(query)).ToList();
            }
        }
    }
}
