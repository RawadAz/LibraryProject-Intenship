using Library.Models.Book;
using Library.Models.NameAndIdDTO;

namespace Library.Repositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<List<string>?> GetBookCategories(string query);
        Task<List<int>> GetBookCopies(string query);
        Task<List<BookDTO>> GetBookDTOAsync(string query);
        Task<List<Name_Id_DTO>> GetBookIdsAndNames(string query);
    }
}
