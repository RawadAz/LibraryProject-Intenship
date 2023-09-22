using Library.Models.Book;
using Library.Models.Branch;
using Library.Models.Client;
using Library.Models.Employee;
using Library.Models.Event;
using Library.Models.Reservation.DTO_s;
using Library.Models.Transactions.DTO_s;
using Library.Repositories;

namespace Library.UnitsOfWork.TransactionsUoW
{
    public interface ITransactionsUnitOfWork
    {

        ITransactionsRepository TransactionsRepository { get; }


        Task<List<TransactionsDTO>> GetAllTransactions();
        Task<List<TransactionsDTO>> GetAllRentTransactions();
        Task<List<TransactionsDTO>> GetAllPurchaseTransactions();
        Task<List<EmployeeSalesDTO>> GetAllEmployeesSales();
        Task<List<TopSellingBookDTO>> GetTopFiveSellingBooks();
        Task<List<BookReturnDTO>?> GetBookReturnDates(string book_Name, string branch_Name);
        Task<List<TransactionsDTO>?> GetTransactionsByClient(string phone_Number);
        Task<TransactionsDTO?> GetTransactionByID(int id);
        Task<int> DeleteTransactionById(int id);
        Task<int> InsertTransaction(EditTransactionsDTO dto);
        Task<int> UpdateTransaction(int id, EditTransactionsDTO dto);
        Task<int> UpdateTransactionStatus(int id);
    }
}
