using Library.Models.DashBoard;
using Library.Models.NameAndIdDTO;

namespace Library.Repositories
{
    public interface IDashboardRepository : IGenericRepository<DashBoardSalesInfo>
    {
        Task<IEnumerable<SalesChartInfo>> GetSalesChartInfo(string sqlQuery);
        Task<IEnumerable<TopBooksChartInfo>> GetTopBooksChartInfo(string sqlQuery);
        Task<IEnumerable<Name_Id_DTO>> GetTopThreeEmployees(string sqlQuery);
    }
}
