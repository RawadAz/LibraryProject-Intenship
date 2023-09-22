using ClassLibrary.Helper;
using ClassLibrary.HttpClients.GenericHC;
using ClassLibrary.Models.Event.DTO;
using ClassLibrary.Models.IdAndNameDTO;
using System.Net;

namespace ClassLibrary.HttpClients.EventHC
{
    public class EventHttpClient : GenericHttpClient<EventDTO>
    {
        private readonly string _baseUrl = "https://localhost:7049/api/Event";

        public async Task<IEnumerable<NameAndIdDTO>> GetEventIdsAndNames()
        {
            var url = _baseUrl + "/NamesAndIds";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<NameAndIdDTO> namesAndIds = await response.Content.ReadAsAsync<IEnumerable<NameAndIdDTO>>();

                if (namesAndIds.Any())
                    return namesAndIds;
            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<string>> GetEventNamesByBranchId(int id)
        {
            string url = _baseUrl + $"/NamesByBranch/{id}";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<string> eventNames = await response.Content.ReadAsAsync<IEnumerable<string>>();

                if (eventNames != null)
                    return eventNames;
            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<int> GetAvaialableTickets(int id)
        {
            string url = _baseUrl + $"/Available_Seats/{id}";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<int> eventNames = await response.Content.ReadAsAsync<IEnumerable<int>>();

                if (eventNames != null)
                    return eventNames.First();
            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }
    }
}
