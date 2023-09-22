using Library.Models.Book;
using Library.Models.Book.DTO_s;
using Library.Models.Client;
using Library.Repositories;

namespace Library.UnitsOfWork.ClientUoW
{
    public interface IClientUnitOfWork
    {
        IClientRepository ClientRepository { get; }

        Task<int> DeleteClientById(int id);
        Task<string> DeleteClientsByIds(List<int> ids);
        Task<List<int>?> GetAllClientIds();
        Task<List<Client>> GetAllClients();
        Task<List<string>> GetAllClientsPhoneNumbers();
        Task<List<Client>?> GetClientByFirstName(string firstName);
        Task<Client?> GetClientByID(int id);
        Task<Client?> GetClientByPhoneNumber(string phoneNb);
        Task<List<RentedBookDTO>?> GetClientRentedBooks(int client_Id);
        Task<int> InsertClient(Client client);
        Task<int> UpdateClientById(int id, Client client);

    }
}
