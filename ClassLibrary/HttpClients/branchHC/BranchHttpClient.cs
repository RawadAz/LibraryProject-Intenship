using ClassLibrary.Helper;
using ClassLibrary.HttpClients.GenericHC;
using ClassLibrary.Models.Branch;
using ClassLibrary.Models.Branch.DTO;
using ClassLibrary.Models.IdAndNameDTO;
using System.Net;

namespace ClassLibrary.HttpClients.branchHC
{
    public class BranchHttpClient : GenericHttpClient<Branch>
    {

        private readonly string _baseUrl = "https://localhost:7049/api/Branch";

        public async Task<IEnumerable<int>> GetBranchIds()
        {
            string url = _baseUrl + "/Branches_Ids";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<int> Ids = await response.Content.ReadAsAsync<IEnumerable<int>>();

                if (Ids.Any())
                    return Ids;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<NameAndIdDTO>> GetBranchIdsAndNames()
        {
            var url = _baseUrl + "/Ids_And_Names";

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

        public async Task<IEnumerable<string>> GetBranchNames()
        {
            string url = _baseUrl + "/Branch_Names";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<string> names = await response.Content.ReadAsAsync<IEnumerable<string>>();

                if (names.Any())
                    return names;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<BranchLocationDTO>> GetBranchLocations()
        {
            string url = _baseUrl + "/Locations";

            using var httpClient = new LibraryHttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                IEnumerable<BranchLocationDTO> locations = await response.Content.ReadAsAsync<IEnumerable<BranchLocationDTO>>();

                if (locations.Any())
                    return locations;

            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }
    }
}
