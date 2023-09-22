using ClassLibrary.HttpClients.BookHC;
using ClassLibrary.HttpClients.ClientHC;
using ClassLibrary.HttpClients.TransactionHC;
using ClassLibrary.Models.Client;
using ClassLibrary.Models.Employee.DTO_s;
using ClassLibrary.Models.Transaction.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibrary.DataAccess.TransactionDataAccess
{
    public class TransactionDataAccess
    {
        private readonly TransactionHttpClient _TransactionHttpClient;
        private readonly string _url = "/Transactions";

        public TransactionDataAccess()
        {
            _TransactionHttpClient = new TransactionHttpClient();
        }

        public async Task<string> AddTransaction(EditTransactionDTO transactionDTO)
        {

            if (string.IsNullOrEmpty(transactionDTO.Book_Name))
                throw new Exception("Book name is required");

            if (string.IsNullOrEmpty(transactionDTO.Branch_Name))
                throw new Exception("Branch name is required");

            if (string.IsNullOrEmpty(transactionDTO.Employee_Username))
            {
                throw new Exception("Employee username is required");
            }

            if (string.IsNullOrEmpty(transactionDTO.Client_Phone_Number))
                throw new Exception("Client phone number is required");

            if (transactionDTO.Copies < 1)
                throw new Exception("copies should atleast be 1");

            if (transactionDTO.Type != "Purchase" &&
                transactionDTO.Type != "Rent")
                throw new Exception("Invalid Transaction Type");

            if (transactionDTO.Type == "Rent")
            {
                if (transactionDTO.Return_Date_Months < 1 || transactionDTO.Return_Date_Months > 6)
                    throw new Exception("duration should be between 1 and 6 months");
                if (transactionDTO.Late_Penalty_Percentage < 0 || transactionDTO.Late_Penalty_Percentage > 100)
                    throw new Exception("penalty percentage should be between 0 and 100");
            }

            var serializedTransaction = JsonSerializer.Serialize(transactionDTO);
            var requestContent = new StringContent(serializedTransaction, Encoding.UTF8, "application/json");

            return await _TransactionHttpClient.Add(_url, requestContent);
        }

        public async Task<IEnumerable<ReturnDateDTO>> GetReturnDates(string bookName, string? branchName)
        {
            if (string.IsNullOrEmpty(bookName))
                throw new Exception("Book name is required");
            if (string.IsNullOrEmpty(branchName))
                throw new Exception("branch name is required");

            return await _TransactionHttpClient.GetReturnDates(bookName, branchName);
        }

        public async Task<IEnumerable<EmployeeSalesDTO>> GetAllEmployeeSales()
        {
            IEnumerable<EmployeeSalesDTO>? sales = await _TransactionHttpClient.GetAllEmployeeSales();

            if (sales == null)
                throw new Exception("No sales available");
            return sales;
        }

        public async Task<IEnumerable<TransactionDTO>> GetTransactions()
        {
            return await _TransactionHttpClient.GetAll(_url);
        }

        public async Task<TransactionDTO> GetTransactionById(int id)
        {
            if (id <= 0)
                throw new Exception("invalid transaction id");

            string url = _url + $"/{id}";

            return await _TransactionHttpClient.Get(url);
        }

        public async Task<IEnumerable<TransactionDTO>> GetPurchaseTransactions()
        {
            string url = _url + "/Purchase_Transactions";

            return await _TransactionHttpClient.GetAll(url);
        }

        public async Task<IEnumerable<TransactionDTO>> GetRentTransactions()
        {
            string url = _url + "/Rent_Transactions";

            return await _TransactionHttpClient.GetAll(url);
        }

        public async Task<IEnumerable<TransactionDTO>> GetTransactionsByPhoneNumber(string phoneNumber)
        {
            string url = _url + $"/Client_Phone_Number/{phoneNumber}";

            return await _TransactionHttpClient.GetAll(url);
        }

        public async Task<string> DeleteTransaction(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid transaction id");

            string url = _url + $"/{id}";

            return await _TransactionHttpClient.Delete(url);
        }

        public async Task<string> UpdateTransaction(int Id, EditTransactionDTO transaction)
        {
            if (!int.TryParse(transaction.Client_Phone_Number, out int phoneNumber))
                throw new Exception("Client phone number should be numeric");

            string url = _url + $"/{Id}";

            var serializedTransaction = JsonSerializer.Serialize(transaction);
            var requestContent = new StringContent(serializedTransaction, Encoding.UTF8, "application/json");

            return await _TransactionHttpClient.Update(url, requestContent);
        }

        public async Task<string> ReturnBook(int transaction_Id)
        {
            if (transaction_Id <= 0)
                throw new Exception("Invalid transaction Id");

            string url = _url + $"/status/{transaction_Id}";

            return await _TransactionHttpClient.Update(url);
        }
    }
}
