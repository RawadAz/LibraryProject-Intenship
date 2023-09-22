using ClassLibrary.Helper;
using ClassLibrary.HttpClients.GenericHC;
using ClassLibrary.Models.Book;
using ClassLibrary.Models.Book.DTO_s;
using ClassLibrary.Models.IdAndNameDTO;
using System.Net;
using System.Text;

namespace ClassLibrary.HttpClients.BookHC
{
    public class BookHttpClient : GenericHttpClient<BookDTO>
    {
        private readonly string _baseUrl = "https://localhost:7049/api/Book";

        public async Task<Book> GetBookById(int id)
        {
            var url = _baseUrl + $"/{id}";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                Book book = await response.Content.ReadAsAsync<Book>();

                if (book != null)
                    return book;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<string>> GetBookCategories()
        {
            string url = _baseUrl + "/Book_Categories";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<string> bookCategories = await response.Content.ReadAsAsync<IEnumerable<string>>();

                if (bookCategories.Any())
                    return bookCategories;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<NameAndIdDTO>> GetBookNameAndId(int branchId)
        {
            var url = _baseUrl + $"/BookNamesAndIds/{branchId}";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<NameAndIdDTO> namesAndIds = await response.Content.ReadAsAsync<IEnumerable<NameAndIdDTO>>();

                if (namesAndIds.Any())
                    return namesAndIds;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<List<int>> GetBookAvailableCopies(int bookId)
        {
            string url = _baseUrl + $"/Book_Copies/{bookId}";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<int> content = await response.Content.ReadAsAsync<List<int>>();
                return content;
            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }
    }
}
