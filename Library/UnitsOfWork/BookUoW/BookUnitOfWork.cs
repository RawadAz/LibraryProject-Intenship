using Library.Data;
using Library.Models.Book;
using Library.Models.NameAndIdDTO;
using Library.Repositories;
using Library.Repositories.BookRepo;
using Microsoft.IdentityModel.Tokens;

namespace Library.UnitsOfWork.BookUoW
{
    public class BookUnitOfWork : IBookUnitOfWork
    {
        private readonly LibraryDBConnection _Connection;

        public IBookRepository BookRepository { get; private set; }

        public BookUnitOfWork(LibraryDBConnection Connection)
        {
            _Connection = Connection;
            BookRepository = new BookRepository(_Connection);
        }

        public async Task<List<BookDTO>> GetAllBooks()
        {
            string query = "dbo.Get_All_Books;";
            return await BookRepository.GetBookDTOAsync(query);
        }

        public async Task<Book?> GetBookByID(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Get_Book_By_Id @id = {id}";
                return await BookRepository.GetAsync(query);
            }
            return null;
        }

        public async Task<int> InsertBook(Book book)
        {
            if (
              !book.Name.IsNullOrEmpty() &&
              !book.Author.IsNullOrEmpty() &&
              !book.Category.IsNullOrEmpty() &&
              book.Purchase_Price > 0 &&
              book.Rent_Price > 0 &&
              book.Branch_Id > 0 &&
              book.In_Stock > 0 &&
              !book.Description.IsNullOrEmpty()
          )
            {

                string query = $"dbo.Insert_Book" +
                    $" @name = '{book.Name.ToLower()}'," +
                    $" @author = '{book.Author.ToLower()}'," +
                    $" @category = '{book.Category.ToLower()}'," +
                    $" @purchase_price = {book.Purchase_Price}," +
                    $" @rent_price = {book.Rent_Price}," +
                    $" @branch_id = {book.Branch_Id}," +
                    $" @in_stock = {book.In_Stock}," +
                    $" @description = '{book.Description.ToLower()}';";

                return await BookRepository.InsertAsync(query);
            }
            return -1;
        }

        public async Task<int> UpdateBookById(int id, Book book)
        {
            if (
                id > 0 &&
                !book.Name.IsNullOrEmpty() &&
                !book.Author.IsNullOrEmpty() &&
                !book.Category.IsNullOrEmpty() &&
                book.Purchase_Price > 0 &&
                book.Rent_Price > 0 &&
                book.Branch_Id > 0 &&
                book.In_Stock > 0 &&
                !book.Description.IsNullOrEmpty()
            )
            {

                string query = $"dbo.Update_Book" +
                    $" @id = {id}," +
                    $" @name = '{book.Name.ToLower()}'," +
                    $" @author = '{book.Author.ToLower()}'," +
                    $" @category = '{book.Category.ToLower()}'," +
                    $" @purchase_price = {book.Purchase_Price}," +
                    $" @rent_price = {book.Rent_Price}," +
                    $" @branch_id = {book.Branch_Id}," +
                    $" @in_stock = {book.In_Stock}," +
                    $" @description = '{book.Description.ToLower()}';";

                return await BookRepository.UpdateAsync(query);
            }
            return -1;
        }

        public async Task<int> DeleteBookById(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Delete_book_By_Id @id = {id}";
                return await BookRepository.DeleteAsync(query);
            }
            return 0;
        }

        public async Task<List<BookDTO>?> GetBookByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                string query = $"dbo.Get_Book_By_Name @name = '{name}'";
                return await BookRepository.GetBookDTOAsync(query);
            }
            return null;
        }

        public async Task<List<BookDTO>?> GetBookByAuthor(string author)
        {
            if (!string.IsNullOrEmpty(author))
            {
                string query = $"dbo.Get_Books_By_Author @author = '{author}'";
                return await BookRepository.GetBookDTOAsync(query);
            }
            return null;
        }

        public async Task<List<BookDTO>?> GetBookByCategory(string category)
        {
            if (!string.IsNullOrEmpty(category))
            {
                string query = $"dbo.Get_Books_By_Category @category = '{category}'";
                return await BookRepository.GetBookDTOAsync(query);
            }
            return null;
        }

        public async Task<List<string>?> GetBookCategories()
        {
            string query = "dbo.Get_All_Book_Categories";
            return await BookRepository.GetBookCategories(query);
        }

        public async Task<List<Name_Id_DTO>> GetBookIdsByBranch(int branchId)
        {
            string query = $"dbo.Get_Book_Ids_And_Names_By_Branch @branch_id = {branchId}";
            return await BookRepository.GetBookIdsAndNames(query);
        }

        public async Task<List<int>> GetBookCopies(int bookId)
        {
            string query = $"dbo.Get_Book_Copies_By_Id @book_id = {bookId}";
            return await BookRepository.GetBookCopies(query);
        }
    }
}
