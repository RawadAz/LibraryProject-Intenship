using Library.Models.Book;
using Library.Models.NameAndIdDTO;
using Library.Repositories;

namespace Library.UnitsOfWork.BookUoW
{
    public interface IBookUnitOfWork
    {
        IBookRepository BookRepository { get; }


        Task<List<BookDTO>> GetAllBooks();
        Task<Book?> GetBookByID(int id);
        Task<int> InsertBook(Book book);
        Task<int> UpdateBookById(int id, Book book);
        Task<int> DeleteBookById(int id);
        Task<List<BookDTO>?> GetBookByName(string name);
        Task<List<BookDTO>?> GetBookByAuthor(string author);
        Task<List<BookDTO>?> GetBookByCategory(string category);
        Task<List<string>?> GetBookCategories();
        Task<List<Name_Id_DTO>> GetBookIdsByBranch(int branchId);
        Task<List<int>> GetBookCopies(int bookId);
    }
}
