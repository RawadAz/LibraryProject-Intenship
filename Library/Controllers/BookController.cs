using Library.Configurations.CacheService;
using Library.Models.Book;
using Library.Models.NameAndIdDTO;
using Library.UnitsOfWork.BookUoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookUnitOfWork _bookUnitOfWork;
        private readonly ICacheService _cacheService;

        public BookController(IBookUnitOfWork bookUnitOfWork, ICacheService cacheService)
        {
            _bookUnitOfWork = bookUnitOfWork;
            _cacheService = cacheService;
        }


        // GET: api/<bookController>
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetAllbooks()
        {
            //checking cache
            var bookCache = _cacheService.GetData<IEnumerable<BookDTO>>("Books");

            if (!bookCache.IsNullOrEmpty())
                return Ok(bookCache);

            var books = await _bookUnitOfWork.GetAllBooks();

            if (books.IsNullOrEmpty())
                return NotFound("No Books Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData("Books", books, cacheExpiry);

            return Ok(books);
        }

        // GET api/<bookController>/5
        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<Book>> GetbookById(int id)
        {
            //checking cache
            var bookCache = _cacheService.GetData<Book>($"book{id}");

            if (bookCache != null)
                return Ok(bookCache);

            var book = await _bookUnitOfWork.GetBookByID(id);

            if (book == null)
                return NotFound("Invalid Id");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"book{id}", book, cacheExpiry);

            return Ok(book);
        }

        // GET api/<bookController>/Name/{name}
        [HttpGet("Name/{name}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetbookByName(string name)
        {

            var bookList = await _bookUnitOfWork.GetBookByName(name);

            if (bookList.IsNullOrEmpty())
                return NotFound("Book Not Found");

            return Ok(bookList);
        }

        // GET api/<bookController>/Author/{author}
        [HttpGet("Author/{author}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetbookByAuthor(string author)
        {

            var bookList = await _bookUnitOfWork.GetBookByAuthor(author);

            if (bookList.IsNullOrEmpty())
                return NotFound("Book Not Found");

            return Ok(bookList);
        }

        // GET api/<bookController>/Category/{category}
        [HttpGet("Category/{category}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetbookByCategory(string category)
        {

            var bookList = await _bookUnitOfWork.GetBookByCategory(category);

            if (bookList.IsNullOrEmpty())
                return NotFound("Book Not Found");

            return Ok(bookList);
        }

        // GET api/<bookController>/BookNamesAndIds/{Branch_Id}
        [HttpGet("BookNamesAndIds/{branchId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<Name_Id_DTO>>> GetbookIdsByBranch(int branchId)
        {

            var BookNameANdIdList = await _bookUnitOfWork.GetBookIdsByBranch(branchId);

            if (BookNameANdIdList.IsNullOrEmpty())
                return NotFound("No books found in this branch");

            return Ok(BookNameANdIdList);
        }

        // GET api/<bookController>/Book_Categories
        [HttpGet("Book_Categories")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<string>>> GetBookCategories()
        {
            //checking cache
            var categoriesCache = _cacheService.GetData<IEnumerable<string>>("categories");

            if (!categoriesCache.IsNullOrEmpty())
                return Ok(categoriesCache);

            var categoriesList = await _bookUnitOfWork.GetBookCategories();

            if (categoriesList.IsNullOrEmpty())
                return NotFound("no categories found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData("categories", categoriesList, cacheExpiry);

            return Ok(categoriesList);
        }

        // GET api/<bookController>/Book_Copies
        [HttpGet("Book_Copies/{bookId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<int>>> GetBookCopies(int bookId)
        {
            //checking cache
            var CopiesCache = _cacheService.GetData<IEnumerable<int>>($"copies{bookId}");

            if (!CopiesCache.IsNullOrEmpty())
                return Ok(CopiesCache);

            var copies = await _bookUnitOfWork.GetBookCopies(bookId);

            if (copies.IsNullOrEmpty())
                return NotFound("no copies available");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"copies{bookId}", copies, cacheExpiry);

            return Ok(copies);
        }

        // POST api/<bookController>
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> InsertBook(Book book)
        {

            int affected_rows = await _bookUnitOfWork.InsertBook(book);

            if (affected_rows > 0)
            {

                //removing invalid cache

                _cacheService.RemoveData("Books");
                _cacheService.RemoveData("Top_Books");
                _cacheService.RemoveData("categories");

                return Ok("Book Inserted Successfully");
            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            else
                throw new Exception("Insertion failed, Try agian");
        }

        // PUT api/<bookController>/5
        [HttpPut("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
        {
            var affected_rows = await _bookUnitOfWork.UpdateBookById(id, book);
            _cacheService.RemoveData("Top_Books");

            if (affected_rows > 0)
            {

                var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);

                //Removing invalid cache
                _cacheService.RemoveData("Books");
                _cacheService.RemoveData("categories");

                //updating cache
                _cacheService.SetData($"book{id}", book, cacheExpiry);

                return Ok("Book updated successfully");

            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            return NotFound("book Not Found! Check id and try again");
        }

        // DELETE api/<bookController>/5
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> Deletebook(int id)
        {
            int affected_rows = await _bookUnitOfWork.DeleteBookById(id);

            if (affected_rows > 0)
            {
                //removing invalid cache
                _cacheService.RemoveData($"book{id}");
                _cacheService.RemoveData("Top_Books"); 
                _cacheService.RemoveData("Books");
                _cacheService.RemoveData("categories");
                _cacheService.RemoveData("Clients");

                return Ok("Book Deleted Successfully");
            }
            return NotFound("Book with id: " + id + " does not exists");
        }
    }
}
