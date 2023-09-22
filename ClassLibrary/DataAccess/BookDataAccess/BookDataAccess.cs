using ClassLibrary.HttpClients.BookHC;
using ClassLibrary.HttpClients.TransactionHC;
using ClassLibrary.Models.Book;
using ClassLibrary.Models.Book.DTO_s;
using ClassLibrary.Models.IdAndNameDTO;
using System.Text;
using System.Text.Json;

namespace ClassLibrary.DataAccess.BookDataAccess
{
    public class BookDataAccess
    {
        private readonly TransactionHttpClient _TransactionHttpClient;
        private readonly BookHttpClient _BookHttpClient;
        private readonly string _url = "/Book";

        public BookDataAccess()
        {
            _TransactionHttpClient = new TransactionHttpClient();
            _BookHttpClient = new BookHttpClient();
        }

        public async Task<IEnumerable<TopSellingBook>> GetTopSellingBooks()
        {

            return await _TransactionHttpClient.GetTopSellingBooks();

        }

        public async Task<IEnumerable<string>?> GetBookCategories()
        {
            return await _BookHttpClient.GetBookCategories();

        }

        public async Task<IEnumerable<BookDTO>> GetBooksByCategory(string category)
        {
            var url = _url + $"/Category/{category}";
            return await _BookHttpClient.GetAll(url);
        }

        public async Task<IEnumerable<BookDTO>> SearchBooks(string? searchMethod, string searchText)
        {
            if (searchMethod == null)
                throw new Exception("please select a valid search method");

            if (searchMethod.Equals("Name"))
            {
                var url = _url + $"/Name/{searchText}";
                return await _BookHttpClient.GetAll(url);
            }
            else if (searchMethod.Equals("Author"))
            {
                var url = _url + $"/Author/{searchText}";
                return await _BookHttpClient.GetAll(url);
            }
            else
                return await GetBooksByCategory(searchText);
        }

        public async Task<Book> GetBookById(int id)
        {

            return await _BookHttpClient.GetBookById(id);
        }

        public async Task<string> AddBook(Book book)
        {
            var serializedBook = JsonSerializer.Serialize(book);
            var requestContent = new StringContent(serializedBook, Encoding.UTF8, "application/json");

            return await _BookHttpClient.Add(_url, requestContent);
        }

        public async Task<IEnumerable<NameAndIdDTO>> GetBookNameAndId(int branchId)
        {
            if (branchId <= 0)
                throw new Exception("Invalid Branch Id");

            return await _BookHttpClient.GetBookNameAndId(branchId);
        }

        public async Task<string> UpdateBook(Book book)
        {
            string url = _url + $"/{book.Id}";

            var serializedBook = JsonSerializer.Serialize(book);
            var requestContent = new StringContent(serializedBook, Encoding.UTF8, "application/json");

            return await _BookHttpClient.Update(url, requestContent);
        }

        public async Task<string> DeleteBook(int id)
        {
            string url = _url + $"/{id}";

            return await _BookHttpClient.Delete(url);
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            return await _BookHttpClient.GetAll(_url);
        }

        public async Task<int> GetBookAvailableCopies(int bookId)
        {
            List<int> copies = await _BookHttpClient.GetBookAvailableCopies(bookId);
            return copies.FirstOrDefault();
        }
    }
}
