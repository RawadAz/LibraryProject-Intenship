using Library.Data;
using Library.Models.DashBoard;
using Library.Models.NameAndIdDTO;
using Library.Repositories;
using Library.Repositories.ClientRepo;
using Library.Repositories.DashboardRepo;

namespace Library.UnitsOfWork.DashboardUoW
{
    public class DashboardUnitOfWork : IDashboardUnitOfWork
    {
        private readonly LibraryDBConnection _Connection;

        public IDashboardRepository DashboardRepository { get; private set; }

        public DashboardUnitOfWork(LibraryDBConnection connection)
        {
            _Connection = connection;
            DashboardRepository = new DashboardRepository(_Connection);
        }

        public async Task<DashBoardSalesInfo> GetDashboardSalesInfo(string startDate)
        {
            string SqlQuery = $"dbo.Get_DashBoard_Top_Info_By_Date @start_date = '{startDate}';";
            return await DashboardRepository.GetAsync(SqlQuery);
        }

        public async Task<IEnumerable<Name_Id_DTO>> GetTopEmployees()
        {
            string SqlQuery = "dbo.Get_Top_Three_Employees;";
            return await DashboardRepository.GetTopThreeEmployees(SqlQuery);
        }

        public async Task<IEnumerable<SalesChartInfo>> GetDashBoardSalesChartInfo(string start_date)
        {
            string SqlQuery;

                SqlQuery = $"dbo.Get_Revenue_By_Date @start_date = '{start_date}'";

            return await DashboardRepository.GetSalesChartInfo(SqlQuery);
        }

        public async Task<IEnumerable<TopBooksChartInfo>> GetTopBooksChartInfo(string start_date)
        {
            string SqlQuery = $"dbo.Get_Dashboard_Top_Books @start_date = '{start_date}';";
            return await DashboardRepository.GetTopBooksChartInfo(SqlQuery);
        }
    }
}
