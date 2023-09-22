using ClassLibrary.HttpClients.DashboardHC;
using ClassLibrary.Models.Dashboard;
using ClassLibrary.Models.IdAndNameDTO;

namespace ClassLibrary.DataAccess.DashboardDataAccess
{
    public class DashboardDataAccess
    {
        private readonly DashboardHttpClient _dashboardHttpClient;
        private readonly string _url = "/Dashboard";
        
        public DashboardDataAccess()
        {
            _dashboardHttpClient = new DashboardHttpClient();
        }

        public async Task<IEnumerable<SalesChartDTO>> GetSalesChartInfo(string startDate)
        {
            string url = $"/Sales_Chart_Info/{startDate}";
            return await _dashboardHttpClient.GetSalesChartInfo(url);
        }

        public async Task<IEnumerable<SalesChartDailyDTO>> GetSalesChartDailyInfo(string startDate)
        {
            string url = $"/Sales_Chart_Info/{startDate}";
            return await _dashboardHttpClient.GetSalesChartDailyInfo(url);
        }

        public async Task<DashboardSalesInfo> GetSalesInfo(string startDate)
        {
            string url = $"{_url}/Sales_Info/{startDate}";
            return await _dashboardHttpClient.Get(url);
        }

        public async Task<IEnumerable<NameAndIdDTO>> GetTopThreeEmployees()
        {
            string url = "/TopEmployees";
            return await _dashboardHttpClient.GetTopEmployees(url);
        }

        public async Task<IEnumerable<TopBookChartInfo>> GetTopBooksChartInfo(string startDate)
        {
            string url = $"/Top_Book_Chart_Info/{startDate}";
            return await _dashboardHttpClient.GetTopBooksChartInfo(url);
        }
    }
}
