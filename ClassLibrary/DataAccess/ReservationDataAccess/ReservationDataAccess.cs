using ClassLibrary.HttpClients.ReservationHC;
using ClassLibrary.Models.Reservation.DTO;
using System.Text;
using System.Text.Json;

namespace ClassLibrary.DataAccess.ReservationDataAccess
{
    public class ReservationDataAccess
    {
        private readonly ReservationHttpClient _reservationsHttpClient;
        private readonly string _url = "/Reservation";

        public ReservationDataAccess()
        {
            _reservationsHttpClient = new ReservationHttpClient();
        }

        public async Task<IEnumerable<ReservationDTO>> GetAllReservations()
        {
            return await _reservationsHttpClient.GetAll(_url);
        }

        public async Task<IEnumerable<ReservationDTO>> GetReservationByPhoneNumber(string? phoneNumber)
        {
            if (phoneNumber == null)
                throw new Exception("Phone number is required");

            bool parsed = int.TryParse(phoneNumber, out int IntegerPhoneNb);
            if (!parsed)
                throw new Exception("Phone number should be numeric");
            if (IntegerPhoneNb <= 0)
                throw new Exception("Invalid phone number");

            string url = _url + $"/{phoneNumber}";

            return await _reservationsHttpClient.GetAll(url);
        }

        public async Task<IEnumerable<ReservationDTO>> GetReservationsByEvent(string? eventName, string branchName)
        {
            if (string.IsNullOrEmpty(eventName))
                throw new Exception("Event name is required");
            if (string.IsNullOrEmpty(branchName))
                throw new Exception("Branch name is required");

            string url = _url + $"/Event_Info?Event_Name={eventName}&Branch_Name={branchName}";

            return await _reservationsHttpClient.GetAll(url);
        }

        public async Task<string> DeleteReservation(DeleteReservationDTO deleteReservation)
        {
            return await _reservationsHttpClient.DeleteReservation(deleteReservation);
        }

        public async Task<string> UpdateReservation(EditReservationDTO reservation)
        {
            var serializedReservation = JsonSerializer.Serialize(reservation);
            var requestContent = new StringContent(serializedReservation, Encoding.UTF8, "application/json");

            return await _reservationsHttpClient.Update(_url, requestContent);
        }

        public async Task<string> AddReservation(EditReservationDTO reservation)
        {
            var serializedReservation = JsonSerializer.Serialize(reservation);
            var requestContent = new StringContent(serializedReservation, Encoding.UTF8, "application/json");

            return await _reservationsHttpClient.Add(_url, requestContent);
        }
    }
}
