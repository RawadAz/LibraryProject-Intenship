using Library.Models.DashBoard;
using Library.Models.NameAndIdDTO;
using Library.Repositories;

namespace Library.UnitsOfWork.DashboardUoW
{
    public interface IDashboardUnitOfWork
    {
        IDashboardRepository DashboardRepository { get; }

        Task<IEnumerable<SalesChartInfo>> GetDashBoardSalesChartInfo(string start_date);
        Task<DashBoardSalesInfo> GetDashboardSalesInfo(string startDate);
        Task<IEnumerable<TopBooksChartInfo>> GetTopBooksChartInfo(string start_date);
        Task<IEnumerable<Name_Id_DTO>> GetTopEmployees();
    }
}
