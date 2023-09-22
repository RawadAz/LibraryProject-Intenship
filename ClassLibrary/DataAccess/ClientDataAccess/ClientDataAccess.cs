using ClassLibrary.HttpClients.ClientHC;
using ClassLibrary.HttpClients.EmployeeHC;
using ClassLibrary.Models.Book.DTO_s;
using ClassLibrary.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibrary.DataAccess.ClientDataAccess
{
    public class ClientDataAccess
    {
        private readonly ClientHttpClient _ClientHttpClient;
        private readonly string _url = "/Client";

        public ClientDataAccess()
        {
            _ClientHttpClient = new ClientHttpClient();
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            return await _ClientHttpClient.GetAll(_url);
        }

        public async Task<IEnumerable<RentedBookDTO>?> GetRentedBooks(int clientId)
        {
            if (clientId <= 0)
                throw new Exception("Invalid client Id");
            return await _ClientHttpClient.GetRentedBooks(clientId);

        }

        public async Task<Client> GetClientById(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid client Id");

            string url = _url + $"/{id}";

            return await _ClientHttpClient.Get(url);
        }

        public async Task<IEnumerable<Client>> GetClientsByFirstname(string firstName)
        {
            string url = _url + $"/first_name/{firstName}";

            return await _ClientHttpClient.GetAll(url);
        }

        public async Task<Client> GetClientsByPhoneNumber(string phoneNumber)
        {
            string url = _url + $"/phone_number/{phoneNumber}";

            return await _ClientHttpClient.Get(url);
        }

        public async Task<string> AddClient(Client client)
        {
            if (!int.TryParse(client.Phone_Number, out int phoneNumber))
                throw new Exception("Client phone number should be numeric");

            var serializedClient = JsonSerializer.Serialize(client);
            var requestContent = new StringContent(serializedClient, Encoding.UTF8, "application/json");

            return await _ClientHttpClient.Add(_url, requestContent);
        }

        public async Task<IEnumerable<int>> GetAllClientIds()
        {
            return await _ClientHttpClient.GetAllClientIds();
        }

        public async Task<string> UpdateClient(Client client)
        {
            if (!int.TryParse(client.Phone_Number, out int phoneNumber))
                throw new Exception("Client phone number should be numeric");

            string url = _url + $"/{client.Id}";

            var serializedClient = JsonSerializer.Serialize(client);
            var requestContent = new StringContent(serializedClient, Encoding.UTF8, "application/json");

            return await _ClientHttpClient.Update(url, requestContent);
        }

        public async Task<string> DeleteClient(int id)
        {
            string url = _url + $"/{id}";

            return await _ClientHttpClient.Delete(url);
        }

        public async Task<string> DeleteMultipleClients(List<int> idsToBeDeleted)
        {
            return await _ClientHttpClient.DeleteMultipleClients(idsToBeDeleted);
        }

        public async Task<IEnumerable<string>> GetClientPhoneNumbers()
        {
            return await _ClientHttpClient.GetClientPhoneNumbers();
        }
    }
}
