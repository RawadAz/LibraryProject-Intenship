using Library.Models.Book;
using Library.Models.Book.DTO_s;
using Library.Models.Client;

namespace Library.Repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<List<int>?> GetAllClientIds(string query);
        Task<List<string>> GetAllClientsPhoneNumbers(string query);
        Task<List<RentedBookDTO>?> GetClientRentedBooks(string query);
    }
}
