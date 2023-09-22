using Dapper;
using Library.Data;
using Library.Models.Book;
using Library.Models.Book.DTO_s;
using Library.Models.Client;
using Library.Repositories.GenericRepo;

namespace Library.Repositories.ClientRepo
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        private new readonly LibraryDBConnection _Connection;

        public IGenericRepository<Client> GenericRepository { get; private set; }

        public ClientRepository(LibraryDBConnection Connection) : base(Connection)
        {
            _Connection = Connection;
            GenericRepository= new GenericRepository<Client>(_Connection);
            
        }

        public async Task<List<RentedBookDTO>?> GetClientRentedBooks(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<RentedBookDTO>(query)).ToList();
        }

        public async Task<List<int>?> GetAllClientIds(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<int>(query)).ToList();
        }

        public async Task<List<string>> GetAllClientsPhoneNumbers(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<string>(query)).ToList();
        }
    }
}
