using Library.Data;
using Library.Models.Book;
using Library.Models.Book.DTO_s;
using Library.Models.Client;
using Library.Repositories;
using Library.Repositories.ClientRepo;
using Microsoft.IdentityModel.Tokens;

namespace Library.UnitsOfWork.ClientUoW
{
    public class ClientUnitOfWork : IClientUnitOfWork
    {
        private readonly LibraryDBConnection _Connection;

        public IClientRepository ClientRepository { get; private set; }

        public ClientUnitOfWork(LibraryDBConnection connection)
        {
            _Connection = connection;
            ClientRepository = new ClientRepository(_Connection);
        }

        public async Task<Client?> GetClientByID(int id)
        {
            if (id > 0)
            {
                string SqlQuery = $"dbo.Get_Client_By_Id @id = {id};";
                return await ClientRepository.GetAsync(SqlQuery);
            }
            return null;
        }

        public async Task<string> DeleteClientsByIds(List<int> ids)
        {
            string query = $"dbo.Delete_Client_By_Id @id = ";
            return await ClientRepository.DeleteAllByIdsAsync(ids, query, "client");
        }

        public async Task<int> DeleteClientById(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Delete_Client_By_Id @id = {id}";
                return await ClientRepository.DeleteAsync(query);
            }
            return 0;
        }

        public async Task<List<Client>> GetAllClients()
        {
            string query = "dbo.Get_All_Clients";
            return await ClientRepository.GetAllAsync(query);
        }

        public async Task<int> InsertClient(Client client)
        {
            if (!client.First_Name.IsNullOrEmpty() && !client.Last_Name.IsNullOrEmpty() && !client.Phone_Number.IsNullOrEmpty() && client.Currently_Rented >= 0)
            {
                string query = $"dbo.Insert_Client @first_name = '{client.First_Name.ToLower()}', @last_name = '{client.Last_Name.ToLower()}', @phone_number = '{client.Phone_Number}',@currently_rented = {client.Currently_Rented};";
                return await ClientRepository.InsertAsync(query);
            }
            return -1;
        }

        public async Task<int> UpdateClientById(int id, Client client)
        {
            if (id > 0 &&
                !client.First_Name.IsNullOrEmpty() &&
                !client.Last_Name.IsNullOrEmpty() &&
                !client.Phone_Number.IsNullOrEmpty() &&
                client.Currently_Rented >= 0)
            {
                string query = $"dbo.Update_Client_By_Id" +
                    $" @id = {id}," +
                    $" @first_name = '{client.First_Name.ToLower()}'," +
                    $" @last_name = '{client.Last_Name.ToLower()}'," +
                    $" @phone_number = '{client.Phone_Number}'," +
                    $" @currently_rented = {client.Currently_Rented};";

                return await ClientRepository.UpdateAsync(query);
            }
            return -1;
        }

        public async Task<Client?> GetClientByPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.IsNullOrEmpty())
                return null;

            string query = $"dbo.Get_Client_By_Phone_Number @phone_number = {phoneNumber};";
            return await ClientRepository.GetAsync(query);


        }

        public async Task<List<Client>?> GetClientByFirstName(string firstName)
        {
            if (firstName.IsNullOrEmpty())
                return null;

            string query = $"dbo.Get_Client_By_First_Name @first_name = {firstName.ToLower()};";
            return await ClientRepository.GetAllAsync(query);

        }

        public async Task<List<RentedBookDTO>?> GetClientRentedBooks(int client_Id)
        {
            if (client_Id <= 0)
                return null;
            string query = $"dbo.Get_Client_Rented_Books_By_Client_Id @client_id = {client_Id}";
            return await ClientRepository.GetClientRentedBooks(query);

        }

        public async Task<List<int>?> GetAllClientIds()
        {
            string query = "dbo.Get_All_Client_Ids";
            return await ClientRepository.GetAllClientIds(query);
        }

        public async Task<List<string>> GetAllClientsPhoneNumbers()
        {
            string query = "dbo.Get_All_client_Phone_Numbers";
            return await ClientRepository.GetAllClientsPhoneNumbers(query);
        }
    }
}
