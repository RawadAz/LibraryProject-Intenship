using ClassLibrary.Helper;
using ClassLibrary.HttpClients.GenericHC;
using ClassLibrary.Models.Book.DTO_s;
using ClassLibrary.Models.Employee.DTO_s;
using ClassLibrary.Models.Transaction.DTOs;
using System.Net;


namespace ClassLibrary.HttpClients.TransactionHC;

public class TransactionHttpClient : GenericHttpClient<TransactionDTO>
{
    private readonly string _baseUrl = "https://localhost:7049/api/Transactions";

    public async Task<IEnumerable<TopSellingBook>> GetTopSellingBooks()
    {
        var url = _baseUrl + "/Top_5_Books";

        using var httpClient = new LibraryHttpClient();
        HttpResponseMessage response = await httpClient.GetAsync(url);

        if (response.StatusCode == HttpStatusCode.OK)
        {

            IEnumerable<TopSellingBook> topSellingBook = await response.Content.ReadAsAsync<IEnumerable<TopSellingBook>>();

            
            return topSellingBook;

        }
        string errorMessage = await response.Content.ReadAsStringAsync();
        throw new Exception(errorMessage);
    }

    public async Task<IEnumerable<ReturnDateDTO>> GetReturnDates(string bookName, string branchName)
    {
        var url = _baseUrl + $"/Book_Return_Dates?book_Name={bookName}&branch_Name={branchName}";

        using var httpClient = new LibraryHttpClient();
        HttpResponseMessage response = await httpClient.GetAsync(url);

        if (response.StatusCode == HttpStatusCode.OK)
        {

            IEnumerable<ReturnDateDTO> returnDates = await response.Content.ReadAsAsync<IEnumerable<ReturnDateDTO>>();


            return returnDates;

        }
        string errorMessage = await response.Content.ReadAsStringAsync();
        throw new Exception(errorMessage);
    }

    public async Task<IEnumerable<EmployeeSalesDTO>?> GetAllEmployeeSales()
    {
        var url = _baseUrl + "/Employee_Sales";

        using var httpClient = new LibraryHttpClient();
        HttpResponseMessage response = await httpClient.GetAsync(url);

        if (response.StatusCode == HttpStatusCode.OK)
        {

            IEnumerable<EmployeeSalesDTO> returnDates = await response.Content.ReadAsAsync<IEnumerable<EmployeeSalesDTO>>();

            return returnDates;
        }
        string errorMessage = await response.Content.ReadAsStringAsync();
        throw new Exception(errorMessage);
    }

}

