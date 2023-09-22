using ClassLibrary.Helper;
using ClassLibrary.HttpClients.GenericHC;
using ClassLibrary.JwtToken;
using ClassLibrary.Models.Dashboard;
using ClassLibrary.Models.IdAndNameDTO;
using System.Net;
using System.Net.Http.Headers;

namespace ClassLibrary.HttpClients.DashboardHC
{
    public class DashboardHttpClient : GenericHttpClient<DashboardSalesInfo>
    {
        private readonly string _baseUrl = "https://localhost:7049/api/Dashboard";

        public async Task<IEnumerable<NameAndIdDTO>> GetTopEmployees(string url)
        {
            url = _baseUrl + url;

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

        public async Task<IEnumerable<SalesChartDTO>> GetSalesChartInfo(string url)
        {
            url = _baseUrl + url;
            
            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                IEnumerable<SalesChartDTO> salesInfo = await response.Content.ReadAsAsync<IEnumerable<SalesChartDTO>>();
                return salesInfo;
            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<SalesChartDailyDTO>> GetSalesChartDailyInfo(string url)
        {
            url = _baseUrl + url;

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                IEnumerable<SalesChartDailyDTO> salesInfo = await response.Content.ReadAsAsync<IEnumerable<SalesChartDailyDTO>>();
                return salesInfo;
            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }

        public async Task<IEnumerable<TopBookChartInfo>> GetTopBooksChartInfo(string url)
        {
            url = _baseUrl + url;

            using var httpClient = new LibraryHttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                IEnumerable<TopBookChartInfo> topBooks = await response.Content.ReadAsAsync<IEnumerable<TopBookChartInfo>>();
                return topBooks;
            }
            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception(errorMessage);
        }
    }
}
