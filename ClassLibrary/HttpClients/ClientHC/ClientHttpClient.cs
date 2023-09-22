using ClassLibrary.Helper;
using ClassLibrary.HttpClients.GenericHC;
using ClassLibrary.Models.Book.DTO_s;
using ClassLibrary.Models.Client;
using System.Net;
using System.Text;
using System.Text.Json;

namespace ClassLibrary.HttpClients.ClientHC
{
    public class ClientHttpClient : GenericHttpClient<Client>
    {
        private readonly string _baseUrl = "https://localhost:7049/api/Client";

        public async Task<IEnumerable<RentedBookDTO>?> GetRentedBooks(int clientId)
        {

            string url = _baseUrl + $"/Rented_Books/{clientId}";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<RentedBookDTO> rentedBooks = await response.Content.ReadAsAsync<IEnumerable<RentedBookDTO>>();

                if (rentedBooks.Any())
                    return rentedBooks;
                return null;
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception(errorMessage);
            }
        }

        public async Task<IEnumerable<int>> GetAllClientIds()
        {
            string url = _baseUrl + "/Client_Ids";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<int> Ids = await response.Content.ReadAsAsync<IEnumerable<int>>();

                if (Ids.Any())
                    return Ids;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<string> DeleteMultipleClients(List<int> ids)
        {
            string url = _baseUrl + "/Multiple";

            var serializedIds = JsonSerializer.Serialize(ids);
            var requestContent = new StringContent(serializedIds, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new()
            {
                Method = HttpMethod.Delete,
                Content = requestContent,
                RequestUri = new Uri(url),
            };

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.SendAsync(request);

            string content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
                return content;

            string errorMessage = content;
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<string>> GetClientPhoneNumbers()
        {
            string url = _baseUrl + "/Clients_Phone_Numbers";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<string> phoneNumbers = await response.Content.ReadAsAsync<IEnumerable<string>>();

                if (phoneNumbers.Any())
                    return phoneNumbers;
                else
                    throw new Exception("Clients phone numbers not found");

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }
    }
}
