using ClassLibrary.HttpClients.EventHC;
using ClassLibrary.Models.Event;
using ClassLibrary.Models.Event.DTO;
using ClassLibrary.Models.IdAndNameDTO;
using System.Text;
using System.Text.Json;

namespace ClassLibrary.DataAccess.EventDataAccess
{
    public class EventDataAccess
    {

        private readonly EventHttpClient _EventHttpClient;
        private readonly string _url = "/event";

        public EventDataAccess()
        {
            _EventHttpClient = new EventHttpClient();
        }

        public async Task<IEnumerable<NameAndIdDTO>> GetEventIdsAndNames()
        {
            return await _EventHttpClient.GetEventIdsAndNames();
        }

        public async Task<IEnumerable<EventDTO>> GetAllEvents()
        {
            return await _EventHttpClient.GetAll(_url);
        }

        public async Task<EventDTO> GetEventByID(int id)
        {
            if (id <= 0)
                throw new Exception("Event not found");

            string url = _url + $"/{id}";

            return await _EventHttpClient.Get(url);
        }

        public async Task<string> AddEvent(Event @event)
        {
            var serializedEvent = JsonSerializer.Serialize(@event);
            var requestContent = new StringContent(serializedEvent, Encoding.UTF8, "application/json");

            return await _EventHttpClient.Add(_url, requestContent);
        }

        public async Task<string> UpdateEvent(Event @event)
        {
            string url = _url + $"/{@event.Id}";

            var serializedEvent = JsonSerializer.Serialize(@event);
            var requestContent = new StringContent(serializedEvent, Encoding.UTF8, "application/json");

            return await _EventHttpClient.Update(url, requestContent);
        }

        public async Task<string> DeleteEvent(int id)
        {
            string url = _url + $"/{id}";

            return await _EventHttpClient.Delete(url);
        }

        public async Task<IEnumerable<string>> GetEventNamesByBranchId(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid Branch Id");
            return await _EventHttpClient.GetEventNamesByBranchId(id);
        }

        public async Task<int> GetAvaialableTickets(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid Branch Id");
            return await _EventHttpClient.GetAvaialableTickets(id);
        }
    }
}
