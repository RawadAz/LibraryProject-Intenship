
using Library.Models.Transactions.DTO_s;

namespace Library.Repositories
{
    public interface ITransactionsRepository : IGenericRepository<TransactionsDTO>
    {
        Task<List<EmployeeSalesDTO>> getAllEmployeeSales(string query);
        Task<List<BookReturnDTO>> getBookReturnDates(string query);
        Task<List<TopSellingBookDTO>> getTopSellingBooks(string query);
    }
}
