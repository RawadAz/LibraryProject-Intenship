using Library.Configurations.CacheService;
using Library.Models.Reservation.DTO_s;
using Library.UnitsOfWork.ReservationUoW;
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
    public class ReservationController : ControllerBase
    {
        private readonly IReservationUnitOfWork _reservationUnitOfWork;
        private readonly ICacheService _cacheService;

        public ReservationController(IReservationUnitOfWork reservationUnitOfWork, ICacheService cacheService)
        {
            _reservationUnitOfWork = reservationUnitOfWork;
            _cacheService = cacheService;
        }


        // GET: api/<ReservationController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservationDTO>>> GetAllReservations()
        {
            //checking cache
            var reservationCache = _cacheService.GetData<IEnumerable<ReservationDTO>>("Reservations");

            if (!reservationCache.IsNullOrEmpty())
                return Ok(reservationCache);

            var reservationslist = await _reservationUnitOfWork.GetAllReservations();

            if (reservationslist.IsNullOrEmpty())
                return NotFound("No Reservations Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData("Reservations", reservationslist, cacheExpiry);

            return Ok(reservationslist);
        }

        // GET api/<ReservationController>/Client_phone_number
        [HttpGet("{client_phone_number}")]
        public async Task<ActionResult<IEnumerable<ReservationDTO>>> GetReservationByClientPhoneNumber(int client_phone_number)
        {
            var reservationCache = _cacheService.GetData<IEnumerable<ReservationDTO>>($"reservation{client_phone_number}");

            if (reservationCache != null)
                return Ok(reservationCache);

            var reservations = await _reservationUnitOfWork.GetReservationByClientPhoneNumber(client_phone_number);

            if (reservations.IsNullOrEmpty())
                return NotFound("No reservation linked to this phone number");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"reservation{client_phone_number}", reservations, cacheExpiry);

            return Ok(reservations);
        }

        // GET api/<ReservationController>/Event_Info
        [HttpGet("Event_Info")]
        public async Task<ActionResult<IEnumerable<ReservationDTO>>> GetReservationByEvent(string Event_Name, string Branch_Name)
        {
            var reservationCache = _cacheService.GetData<IEnumerable<ReservationDTO>>($"reservation{Event_Name + Branch_Name}");

            if (reservationCache != null)
                return Ok(reservationCache);

            var reservation = await _reservationUnitOfWork.GetReservationByEvent(Event_Name, Branch_Name);

            if (reservation.IsNullOrEmpty())
                return NotFound($"No reservations for event: {Event_Name} in branch {Branch_Name}");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"reservation{Event_Name + Branch_Name}", reservation, cacheExpiry);

            return Ok(reservation);
        }

        // POST api/<ReservationController>
        [HttpPost]
        public async Task<IActionResult> InsertReservation(EditReservationDTO dto)
        {

            int affected_rows = await _reservationUnitOfWork.InsertReservation(dto);

            if (affected_rows > 0)
            {

                //removing invalid cache
                _cacheService.RemoveData("Reservations");
                _cacheService.RemoveData("Events");
                _cacheService.RemoveData($"event{dto.Event_Id}");
                _cacheService.RemoveData($"eventSeats{dto.Event_Id}");
                return Ok("Reservation Added Successfully");
            }

            return BadRequest("Reservation failed, please check your info and try again");
        }

        // PUT api/<ReservationController>
        [HttpPut]
        public async Task<IActionResult> UpdateReservation (EditReservationDTO dto)
        {
            var result = await _reservationUnitOfWork.UpdateReservation(dto);

            if (result > 0)
            {
                //Removing invalid cache
                _cacheService.RemoveData("Reservations");

                var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
                _cacheService.RemoveData("Events");
                _cacheService.RemoveData($"event{dto.Event_Id}");
                _cacheService.RemoveData($"eventSeats{dto.Event_Id}");
                _cacheService.SetData($"reservation{dto.Event_Id}", dto, cacheExpiry);
                _cacheService.SetData($"reservation{dto.Client_Phone_Number}", dto, cacheExpiry);

                return Ok("Reservation updated successfully");
            }
            
            return BadRequest("Reservation failed, please check your info and try again"); 
        }

        // DELETE api/<ReservationController>/5
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteReservationDTO dto)
        {
            int affected_rows = await _reservationUnitOfWork.DeleteReservation(dto);

            if (affected_rows > 0)
            {
                //removing invalid cache
                _cacheService.RemoveData("Events");
                _cacheService.RemoveData($"event{dto.Event_Id}");
                _cacheService.RemoveData($"eventSeats{dto.Event_Id}");
                _cacheService.RemoveData($"reservation{dto.Client_Phone_Number}");
                _cacheService.RemoveData($"reservation{dto.Event_Id}");
                _cacheService.RemoveData("Reservations");

                return Ok("Reservation Deleted Successfully");
            }
            return NotFound("reservaton does not exist");
        }
    }
}
