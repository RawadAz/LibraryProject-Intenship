using Dapper;
using Library.Data;
using Library.Models.Book;
using Library.Models.NameAndIdDTO;
using Library.Repositories.GenericRepo;

namespace Library.Repositories.BookRepo
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private new readonly LibraryDBConnection _Connection;

        public IGenericRepository<Book> GenericRepository { get; private set; }

        public BookRepository(LibraryDBConnection connection) : base(connection)
        {
            _Connection = connection;
            GenericRepository = new GenericRepository<Book>(_Connection);
        }

        public async Task<List<BookDTO>> GetBookDTOAsync(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<BookDTO>(query)).ToList();
        }

        public async Task<List<string>?> GetBookCategories(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<string>(query)).ToList();
        }

        public async Task<List<Name_Id_DTO>> GetBookIdsAndNames(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<Name_Id_DTO>(query)).ToList();
        }

        public async Task<List<int>> GetBookCopies(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<int>(query)).ToList();
        }
    }
}
