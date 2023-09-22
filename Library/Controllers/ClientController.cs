using Library.Configurations.CacheService;
using Library.Models.Book.DTO_s;
using Library.Models.Client;
using Library.UnitsOfWork.ClientUoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientUnitOfWork _clientUnitOfWork;
        private readonly ICacheService _cacheService;
        

        public ClientController(IClientUnitOfWork clientUnitOfWork, ICacheService cacheService)
        {
            _clientUnitOfWork = clientUnitOfWork;
            _cacheService = cacheService;
        }

        
        // GET: api/<ClientController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetAllClients()
        {
            //checking cache
            var clientCache = _cacheService.GetData<IEnumerable<Client>>("Clients");

            if(!clientCache.IsNullOrEmpty())
                return Ok(clientCache);

            var clients = await _clientUnitOfWork.GetAllClients();

            if(clients.IsNullOrEmpty())
                return NotFound("Client Not Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<Client>>("Clients", clients, cacheExpiry);

            return Ok(clients);
        }

        
        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClientById(int id)
        {
            //checking cache
            var clientCache = _cacheService.GetData<Client>($"client{id}");

            if (clientCache != null)
                return Ok(clientCache);

            var client = await _clientUnitOfWork.GetClientByID(id);

            if(client == null)
                return NotFound("Invalid Id");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"client{id}", client, cacheExpiry);

            return Ok(client);
        }

        // GET api/<ClientController>/phone_number/
        [HttpGet("phone_number/{phoneNb}")]
        public async Task<ActionResult<Client>> GetClientbyPhoneNb(string phoneNb)
        {
            //checking cache
            var clientCache = _cacheService.GetData<Client>($"client{phoneNb}");

            if (clientCache != null)
                return Ok(clientCache);

            var client = await _clientUnitOfWork.GetClientByPhoneNumber(phoneNb);

            if (client == null)
                 return NotFound("Invalid Phone Number");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);
            _cacheService.SetData($"client{phoneNb}", client, cacheExpiry);

            return Ok(client);
            
        }


        // GET api/<ClientController>/first_name/
        [HttpGet("first_name/{firstName}")]
        public async Task<ActionResult<List<Client>>> GetClientbyFirstName(string firstName)
        {
            //checking cache
            var clientCache = _cacheService.GetData<List<Client>>($"client{firstName}");

            if (!clientCache.IsNullOrEmpty())
                return Ok(clientCache);

            var clients = await _clientUnitOfWork.GetClientByFirstName(firstName);

            if (clients.IsNullOrEmpty())
                 return NotFound("No Clients Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);
            _cacheService.SetData($"client{firstName}", clients, cacheExpiry);

            return Ok(clients);
        }

        // GET api/<ClientController>/Rented_Books/5
        [HttpGet("Rented_Books/{Client_Id}")]
        public async Task<ActionResult<IEnumerable<RentedBookDTO>>> GetClientRentedBooks(int Client_Id)
        {
           
            var rentedBooks = await _clientUnitOfWork.GetClientRentedBooks(Client_Id);

            if (rentedBooks == null)
                return NotFound("Invalid Id");

            return Ok(rentedBooks);
        }

        // GET api/<ClientController>/Client_Ids
        [HttpGet("Client_Ids")]
        public async Task<ActionResult<IEnumerable<int>>> GetAllClientIds()
        {

            var ids = await _clientUnitOfWork.GetAllClientIds();

            if (ids.IsNullOrEmpty())
                return NotFound("No client Ids found");

            return Ok(ids);
        }

        // GET api/<ClientController>/Clients_Phone_Numbers
        [HttpGet("Clients_Phone_Numbers")]
        public async Task<ActionResult<IEnumerable<string>>> GetAllClientsPhoneNumbers()
        {

            var phoneNumbers = await _clientUnitOfWork.GetAllClientsPhoneNumbers();

            if (phoneNumbers.IsNullOrEmpty())
                return NotFound("No client phone numbers found");

            return Ok(phoneNumbers);
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<IActionResult> InsertClient(Client client)
        {
            
            int affected_rows = await _clientUnitOfWork.InsertClient(client);

            if (affected_rows > 0) {

                //removing invalid cache
                _cacheService.RemoveData("Clients");

                //updating cache
                var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);
                _cacheService.SetData($"client{client.First_Name}", client, cacheExpiry);

                return Ok("Client Inserted Successfully");
            }
            else if (affected_rows == -1) { 
                return BadRequest("something went wrong, please check your info and try again");
            }
            else
                throw new Exception("Insertion failed, Try agian");
        }


        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, Client client)
        {
            var affectedd_rows = await _clientUnitOfWork.UpdateClientById(id, client);
            
            if (affectedd_rows > 0) {

                var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);

                //Removing invalid cache
                _cacheService.RemoveData("Clients");

                //updating cache
                _cacheService.SetData($"client{id}", client, cacheExpiry);
                _cacheService.SetData($"{client.Phone_Number}", client, cacheExpiry);
                _cacheService.SetData($"{client.First_Name}", client, cacheExpiry);

                return Ok("client updated successfully");

            }
            else if(affectedd_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            return NotFound("Client Not Found! Check id and try again");
        }

        //done
        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            int affected_rows = await _clientUnitOfWork.DeleteClientById(id);

            if (affected_rows > 0) 
            {
                //removing invalid cache
                _cacheService.RemoveData($"client{id}");
                _cacheService.RemoveData("Clients");

                return Ok("Client Deleted Successfully");
            }
            return NotFound("Client with id: "+ id +" does not exists");          
        }

        // DELETE api/<ClientController>/Multiple
        [HttpDelete("Multiple")]
        public async Task<IActionResult> DeleteMultipleByIds(List<int> ids)
        {
            string result = await _clientUnitOfWork.DeleteClientsByIds(ids);

            //removing invalid cache
            _cacheService.RemoveData("Clients");

            foreach (int id in ids)
            {
                _cacheService.RemoveData($"client{id}");
            }

            return Ok(result);            
        }
    }
}
