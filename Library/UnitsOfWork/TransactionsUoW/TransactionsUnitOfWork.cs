using Library.Data;
using Library.Models.Book;
using Library.Models.Branch;
using Library.Models.Client;
using Library.Models.Employee;
using Library.Models.Event;
using Library.Models.Reservation.DTO_s;
using Library.Models.Transactions.DTO_s;
using Library.Repositories;
using Library.Repositories.BookRepo;
using Library.Repositories.BranchRepo;
using Library.Repositories.ClientRepo;
using Library.Repositories.EmployeeRepo;
using Library.Repositories.EventRepo;
using Library.Repositories.ReservationRepo;
using Library.Repositories.TransactionsRepo;
using Microsoft.IdentityModel.Tokens;

namespace Library.UnitsOfWork.TransactionsUoW
{
    public class TransactionsUnitOfWork : ITransactionsUnitOfWork
    {
        private readonly LibraryDBConnection _Connection;


        public ITransactionsRepository TransactionsRepository { get; private set; }

        public TransactionsUnitOfWork(LibraryDBConnection connection)
        {
            _Connection = connection;
            TransactionsRepository = new TransactionsRepository(_Connection);
        }

        public async Task<List<TransactionsDTO>> GetAllTransactions()
        {
            string query = "dbo.Get_All_Transactions;";
            return await TransactionsRepository.GetAllAsync(query);
        }
        public async Task<List<TransactionsDTO>> GetAllRentTransactions()
        {
            string query = "dbo.Get_All_Rent_Transactions;";
            return await TransactionsRepository.GetAllAsync(query);
        }
        public async Task<List<TransactionsDTO>> GetAllPurchaseTransactions()
        {
            string query = "dbo.Get_All_Purchase_Transactions;";
            return await TransactionsRepository.GetAllAsync(query);
        }

        public async Task<List<EmployeeSalesDTO>> GetAllEmployeesSales()
        {
            string query = "dbo.Get_Total_Sales_For_Each_Employee;";
            return await TransactionsRepository.getAllEmployeeSales(query);
        }

        public async Task<List<TopSellingBookDTO>> GetTopFiveSellingBooks()
        {
            string query = "dbo.Get_Top_Five_Selling;";
            return await TransactionsRepository.getTopSellingBooks(query);
        }

        public async Task<List<BookReturnDTO>?> GetBookReturnDates(string book_Name, string branch_Name)
        {
            if (book_Name.IsNullOrEmpty())
                throw new BadHttpRequestException("Book name is required");
            if (branch_Name.IsNullOrEmpty())
                throw new BadHttpRequestException("Branch name is required");

            string query = $"dbo.Get_Nearest_Return_Date_By_Book @book_name = '{book_Name.ToLower()}', @branch_name = '{branch_Name.ToLower()}';";
            return await TransactionsRepository.getBookReturnDates(query);

        }

        public async Task<List<TransactionsDTO>?> GetTransactionsByClient(string phone_Number)
        {
            if (phone_Number.IsNullOrEmpty())
                throw new BadHttpRequestException("Phone number is required");

            string query = $"dbo.Get_Transaction_By_Client_Phone_Number @phone_number = '{phone_Number}';";
            return await TransactionsRepository.GetAllAsync(query);
        }

        public async Task<TransactionsDTO?> GetTransactionByID(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Get_Transaction_By_Id @id = {id};";
                return await TransactionsRepository.GetAsync(query);
            }
            return null;
        }

        public async Task<int> DeleteTransactionById(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Delete_Transaction_By_Id @id = {id};";
                return await TransactionsRepository.DeleteAsync(query);
            }
            return 0;
        }

        public async Task<int> InsertTransaction(EditTransactionsDTO dto)
        {
            if (
                !dto.Client_Phone_Number.IsNullOrEmpty() &&
                !dto.Book_Name.IsNullOrEmpty() &&
                !dto.Branch_Name.IsNullOrEmpty() &&
                !dto.Employee_Username.IsNullOrEmpty() &&
                !dto.Type.IsNullOrEmpty() &&
                dto.Copies > 0 &&
                (!dto.Return_Date_Months.HasValue || dto.Return_Date_Months > 0) &&
                (!dto.Late_Penalty_Percentage.HasValue || dto.Late_Penalty_Percentage > 0)
            )
            {


                string query = $"dbo.Insert_Transaction" +
                    $" @client_phone_number = '{dto.Client_Phone_Number}'," +
                    $" @book_name = '{dto.Book_Name.ToLower()}'," +
                    $" @branch_name = '{dto.Branch_Name.ToLower()}'," +
                    $" @employee_username = '{dto.Employee_Username}'," +
                    $" @type = '{dto.Type.ToLower()}'," +
                    $" @copies = {dto.Copies}," +
                    $" @return_date_months = {dto.Return_Date_Months}," +
                    $" @late_penalty_percentage = {dto.Late_Penalty_Percentage};";

                return await TransactionsRepository.InsertAsync(query);
            }
            return -1;
        }

        public async Task<int> UpdateTransaction(int id, EditTransactionsDTO dto)
        {
            if (
                id > 0 &&
                !dto.Client_Phone_Number.IsNullOrEmpty() &&
                !dto.Book_Name.IsNullOrEmpty() &&
                !dto.Branch_Name.IsNullOrEmpty() &&
                !dto.Employee_Username.IsNullOrEmpty() &&
                !dto.Type.IsNullOrEmpty() &&
                dto.Copies > 0 &&
                (!dto.Return_Date_Months.HasValue || dto.Return_Date_Months > 0) &&
                (!dto.Late_Penalty_Percentage.HasValue || dto.Late_Penalty_Percentage > 0)
            )
            {
                string query = $"dbo.Update_Transaction" +
                    $" @id = {id}," +
                    $" @client_phone_number = '{dto.Client_Phone_Number}'," +
                    $" @book_name = '{dto.Book_Name.ToLower()}'," +
                    $" @branch_name = '{dto.Branch_Name.ToLower()}'," +
                    $" @employee_username = '{dto.Employee_Username}'," +
                    $" @type = '{dto.Type.ToLower()}'," +
                    $" @copies = {dto.Copies}," +
                    $" @return_date_months = {dto.Return_Date_Months}," +
                    $" @late_penalty_percentage = {dto.Late_Penalty_Percentage};";

                return await TransactionsRepository.UpdateAsync(query);
            }
            return -1;
        }

        public async Task<int> UpdateTransactionStatus(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Return_Rented_Book_By_Transaction_Id @transaction_id = {id};";

                return await TransactionsRepository.UpdateAsync(query);
            }
            return -1;
        }
    }
}
