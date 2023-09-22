using Dapper;
using Library.Data;
using Library.Models.Book.DTO_s;
using Library.Models.DashBoard;
using Library.Models.NameAndIdDTO;
using Library.Repositories.GenericRepo;
using LiteDB;

namespace Library.Repositories.DashboardRepo
{
    public class DashboardRepository : GenericRepository<DashBoardSalesInfo>, IDashboardRepository
    {
        private new readonly LibraryDBConnection _Connection;
        public IGenericRepository<DashBoardSalesInfo> GenericRepository { get; private set; }

        public DashboardRepository(LibraryDBConnection Connection) : base(Connection)
        {
            _Connection = Connection;
            GenericRepository = new GenericRepository<DashBoardSalesInfo>(_Connection);
        }

        public async Task<IEnumerable<Name_Id_DTO>> GetTopThreeEmployees(string sqlQuery)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<Name_Id_DTO>(sqlQuery)).ToList();
        }

        public async Task<IEnumerable<SalesChartInfo>> GetSalesChartInfo(string sqlQuery)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<SalesChartInfo>(sqlQuery)).ToList();
        }

        public async Task<IEnumerable<TopBooksChartInfo>> GetTopBooksChartInfo(string sqlQuery)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<TopBooksChartInfo>(sqlQuery)).ToList();
        }
    }
}
