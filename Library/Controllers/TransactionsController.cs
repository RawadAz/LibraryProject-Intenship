using Library.Configurations.CacheService;
using Library.Models.Transactions.DTO_s;
using Library.UnitsOfWork.TransactionsUoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsUnitOfWork _transactionsUnitOfWork;
        private readonly ICacheService _cacheService;

        public TransactionsController(ITransactionsUnitOfWork transactionsUnitOfWork, ICacheService cacheService)
        {
            _transactionsUnitOfWork = transactionsUnitOfWork;
            _cacheService = cacheService;
        }
        // GET: api/<TransactionsController>
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<TransactionsDTO>>> GetAllTransactions()
        {
            var transactionsCache = _cacheService.GetData<IEnumerable<TransactionsDTO>>("Transactions");

            if (!transactionsCache.IsNullOrEmpty())
                return Ok(transactionsCache);

            var transactions = await _transactionsUnitOfWork.GetAllTransactions();

            if (transactions.IsNullOrEmpty())
                return NotFound("No transactions Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<TransactionsDTO>>("Transactions", transactions, cacheExpiry);

            return Ok(transactions);
        }

        // GET: api/<TransactionsController>/Rent_Transactions
        [HttpGet("Rent_Transactions")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<TransactionsDTO>>> GetAllRentTransactions()
        {
            var transactionsCache = _cacheService.GetData<IEnumerable<TransactionsDTO>>("Rent_Transactions");

            if (!transactionsCache.IsNullOrEmpty())
                return Ok(transactionsCache);

            var transactions = await _transactionsUnitOfWork.GetAllRentTransactions();

            if (transactions.IsNullOrEmpty())
                return NotFound("No transactions Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<TransactionsDTO>>("Rent_Transactions", transactions, cacheExpiry);

            return Ok(transactions);
        }

        // GET: api/<TransactionsController>/Purchase_Transactions
        [HttpGet("Purchase_Transactions")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<TransactionsDTO>>> GetAllPurchaseTransactions()
        {
            var transactionsCache = _cacheService.GetData<IEnumerable<TransactionsDTO>>("Purchase_Transactions");

            if (!transactionsCache.IsNullOrEmpty())
                return Ok(transactionsCache);

            var transactions = await _transactionsUnitOfWork.GetAllPurchaseTransactions();

            if (transactions.IsNullOrEmpty())
                return NotFound("No transactions Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<TransactionsDTO>>("Purchase_Transactions", transactions, cacheExpiry);

            return Ok(transactions);
        }

        // GET: api/<TransactionsController>/Employee_Sales
        [HttpGet("Employee_Sales")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<EmployeeSalesDTO>>> GetAllEmployeesSales()
        {
            var salesCache = _cacheService.GetData<IEnumerable<EmployeeSalesDTO>>("Employee_Sales");

            if (!salesCache.IsNullOrEmpty())
                return Ok(salesCache);

            var employee_Sales = await _transactionsUnitOfWork.GetAllEmployeesSales();

            if (employee_Sales.IsNullOrEmpty())
                return NotFound("No sales Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<EmployeeSalesDTO>>("Employee_Sales", employee_Sales, cacheExpiry);

            return Ok(employee_Sales);
        }

        // GET: api/<TransactionsController>/Client_Phone_Number
        [HttpGet("Client_Phone_Number/{Phone_Number}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<TransactionsDTO>>> GetTransactionsByClient(string Phone_Number)
        {
            var transactionsCache = _cacheService.GetData<IEnumerable<TransactionsDTO>>($"Transactions{Phone_Number}");

            if (!transactionsCache.IsNullOrEmpty())
                return Ok(transactionsCache);

            var transactions = await _transactionsUnitOfWork.GetTransactionsByClient(Phone_Number);

            if (transactions.IsNullOrEmpty())
                return NotFound("No transactions Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(1);
            _cacheService.SetData<IEnumerable<TransactionsDTO>?>($"Transactions{Phone_Number}", transactions, cacheExpiry);

            return Ok(transactions);
        }

        // GET: api/<TransactionsController>/Top_5_Books
        [HttpGet("Top_5_Books")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<TopSellingBookDTO>>> GetTopFiveSellingBooks()
        {
            var TopBooksCache = _cacheService.GetData<IEnumerable<TopSellingBookDTO>>("Top_Books");

            if (!TopBooksCache.IsNullOrEmpty())
                return Ok(TopBooksCache);

            var TopBooks = await _transactionsUnitOfWork.GetTopFiveSellingBooks();

            if (TopBooks.IsNullOrEmpty())
                return NotFound("No books sold yet");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<TopSellingBookDTO>>("Top_Books", TopBooks, cacheExpiry);

            return Ok(TopBooks);
        }

        // GET: api/<TransactionsController>/Book_Return_Dates
        [HttpGet("Book_Return_Dates")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<BookReturnDTO>>> GetBookReturnDates(string book_Name, string branch_Name)
        {
            var returnDatesCache = _cacheService.GetData<IEnumerable<BookReturnDTO>>($"Return_Dates{book_Name + branch_Name}");

            if (!returnDatesCache.IsNullOrEmpty())
                return Ok(returnDatesCache);

            var returnDates = await _transactionsUnitOfWork.GetBookReturnDates(book_Name, branch_Name);

            if (returnDates.IsNullOrEmpty())
                return NotFound("No such book on the return list");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);
            _cacheService.SetData<IEnumerable<BookReturnDTO>?>($"return_date{book_Name + branch_Name}", returnDates, cacheExpiry);

            return Ok(returnDates);
        }

        // GET api/<TransactionsController>/5
        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<TransactionsDTO>> GetTransactionById(int id)
        {
            //checking cache
            var transactionCache = _cacheService.GetData<TransactionsDTO>($"transaction{id}");

            if (transactionCache != null)
                return Ok(transactionCache);

            var transaction = await _transactionsUnitOfWork.GetTransactionByID(id);

            if (transaction == null)
                return NotFound("Invalid Id");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"transaction{id}", transaction, cacheExpiry);

            return Ok(transaction);
        }

        // POST api/<TransactionsController>
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> InsertTransaction (EditTransactionsDTO dto) 
        {

            int affected_rows = await _transactionsUnitOfWork.InsertTransaction(dto);

            if (affected_rows > 0)
            {

                //removing invalid cache
                _cacheService.RemoveData("Transactions");
                _cacheService.RemoveData("Rent_Transactions");
                _cacheService.RemoveData("Purchase_Transactions");
                _cacheService.RemoveData("Top_Books");
                _cacheService.RemoveData("Employee_Sales");
                _cacheService.RemoveData("Clients");
                _cacheService.RemoveData("Books");
                _cacheService.RemoveData($"book{dto.Book_Name}");
                _cacheService.RemoveData($"client{dto.Client_Phone_Number}");

                return Ok("Transaction Added Successfully");
            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            else
                throw new Exception("Insertion failed, Try agian");
        }

        // PUT api/<TransactionsController>/5
        [HttpPut("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> UpdateTransaction(int id, EditTransactionsDTO dto)
        {
            var affected_rows = await _transactionsUnitOfWork.UpdateTransaction(id, dto);

            if (affected_rows > 0)
            {
                //Removing invalid cache
                
                _cacheService.RemoveData("Transactions");
                _cacheService.RemoveData($"tranaction{id}");
                _cacheService.RemoveData("Rent_Transactions");
                _cacheService.RemoveData("Purchase_Transactions");
                _cacheService.RemoveData("Top_Books");
                _cacheService.RemoveData("Employee_Sales");
                _cacheService.RemoveData("Clients");
                _cacheService.RemoveData("Books");
                _cacheService.RemoveData($"client{dto.Client_Phone_Number}");

                return Ok("Transaction updated successfully");
            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            return NotFound("UPDATE FAILED! Transaction Not Found! Check id and try again");
        }

        // PUT api/<TransactionsController>/status/5
        [HttpPut("status/{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> UpdateTransactionStatus(int id)
        {
            var affected_rows = await _transactionsUnitOfWork.UpdateTransactionStatus(id);

            if (affected_rows > 0)
            {
                //Removing invalid cache

                _cacheService.RemoveData("Transactions");
                _cacheService.RemoveData($"tranaction{id}");
                _cacheService.RemoveData("Rent_Transactions");
                _cacheService.RemoveData("Purchase_Transactions");
                _cacheService.RemoveData("Top_Books");
                _cacheService.RemoveData("Employee_Sales");
                _cacheService.RemoveData("Clients");
                _cacheService.RemoveData("Books");

                return Ok("Book(s) returned");
            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            return NotFound("UPDATE FAILED! Transaction Not Found! Check id and try again");
        }

        // DELETE api/<TransactionsController>/5
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> DeleteTransactionById(int id)
        {
            int affected_rows = await _transactionsUnitOfWork.DeleteTransactionById(id);

            if (affected_rows > 0)
            {
                //removing invalid cache
                _cacheService.RemoveData($"tranaction{id}");
                _cacheService.RemoveData("Transactions");
                _cacheService.RemoveData("Rent_Transactions");
                _cacheService.RemoveData("Purchase_Transactions");
                _cacheService.RemoveData("Top_Books");
                _cacheService.RemoveData("Employee_Sales");
                _cacheService.RemoveData("Clients");
                _cacheService.RemoveData("Books");

                return Ok("Transaction Deleted Successfully");
            }
            return NotFound("Transaction with id = " + id + " does not exists");
        }
    }
}
