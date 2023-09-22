using Library.Configurations.CacheService;
using Library.Models.Event;
using Library.Models.Event.DTO;
using Library.Models.NameAndIdDTO;
using Library.UnitsOfWork.EventUoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventUnitOfWork _eventUnitOfWork;
        private readonly ICacheService _cacheService;

        public EventController(IEventUnitOfWork eventUnitOfWork, ICacheService cacheService)
        {
            _eventUnitOfWork = eventUnitOfWork;
            _cacheService = cacheService;
        }


        // GET: api/<EventController>
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<EventDTO>>> GetAllEvents()
        {
            //checking cache
            var eventCache = _cacheService.GetData<IEnumerable<EventDTO>>("Events");

            if (!eventCache.IsNullOrEmpty())
                return Ok(eventCache);

            var events = await _eventUnitOfWork.GetAllEvents();

            if (events.IsNullOrEmpty())
                return NotFound("No Events Available");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<EventDTO>>("Events", events, cacheExpiry);

            return Ok(events);
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<EventDTO>> GetEventById(int id)
        {
            //checking cache
            var eventCache = _cacheService.GetData<EventDTO>($"event{id}");

            if (eventCache != null)
                return Ok(eventCache);

            var @event  = await _eventUnitOfWork.GetEventByID(id);

            if (@event == null)
                return NotFound("Invalid Id");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"event{id}", @event, cacheExpiry);

            return Ok(@event);
        }

        // GET api/<EventController>/5
        [HttpGet("Available_Seats/{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<int>>> GetEventAvaialbleSeatsById(int id)
        {
            //checking cache
            var eventCache = _cacheService.GetData<IEnumerable<int>>($"eventSeats{id}");

            if (!eventCache.IsNullOrEmpty())
                return Ok(eventCache);

            IEnumerable<int> seats = await _eventUnitOfWork.GetEventAvaialbleSeatsById(id);

            if (seats == null)
                return NotFound("Event Not Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"eventSeats{id}", seats, cacheExpiry);

            return Ok(seats);
        }

        // GET api/<bookController>/NamesAndIds
        [HttpGet("NamesAndIds")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<Name_Id_DTO>>> GetEventIdsAndNames()
        {

            var NameANdIdList = await _eventUnitOfWork.GetEventIdsAndNames();

            if (NameANdIdList.IsNullOrEmpty())
                return NotFound("No events found in this branch");

            return Ok(NameANdIdList);
        }

        // GET api/<bookController>/NamesAndIds
        [HttpGet("NamesByBranch/{branchId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<string>>> GetEventNamesByBranch(int branchId)
        {

            var eventNames = await _eventUnitOfWork.GetEventNamesByBranch(branchId);

            if (eventNames.IsNullOrEmpty())
                return NotFound("No Events found in this branch");

            return Ok(eventNames);
        }

        // POST api/<EventController>
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> InsertEvent(Event @event)
        {

            int affected_rows = await _eventUnitOfWork.InsertEvent(@event);

            if (affected_rows > 0)
            {

                //removing invalid cache
                _cacheService.RemoveData("Events");

                return Ok("Event Added Successfully");
            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            else
                throw new Exception("Insertion failed, Try agian");
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> UpdateEvent(int id, Event @event)
        {
            var affected_rows = await _eventUnitOfWork.UpdateEventById(id, @event);

            if (affected_rows > 0)
            {

                var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);

                //Removing invalid cache
                _cacheService.RemoveData("Events");

                //updating cache
                _cacheService.SetData($"event{id}", @event, cacheExpiry);

                return Ok("Event updated successfully");

            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            return NotFound("Event Not Found! Check id and try again");
        }

        // PUT api/<EventController>/Event_seats/5
        [HttpPut("Event_Seats/{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> UpdateEventSeats(int id, int Event_Seats)
        {
            var affected_rows = await _eventUnitOfWork.UpdateEventSeats(id, Event_Seats);

            if (affected_rows > 0)
            {
                //Removing invalid cache
                _cacheService.RemoveData("Events");
                _cacheService.RemoveData($"event{id}");

                return Ok("Number of available seats updated successfully");

            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            return NotFound("Event Not Found! Check id and try again");
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            int affected_rows = await _eventUnitOfWork.DeleteEventById(id);

            if (affected_rows > 0)
            {
                //removing invalid cache
                _cacheService.RemoveData($"event{id}");
                _cacheService.RemoveData($"eventSeats{id}");
                _cacheService.RemoveData("Events");

                return Ok("Event Removed Successfully");
            }
            return NotFound("Event with id: " + id + " does not exists");
        }
    }
}
