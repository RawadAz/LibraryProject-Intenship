using Library.Configurations.CacheService;
using Library.Models.DashBoard;
using Library.Models.NameAndIdDTO;
using Library.UnitsOfWork.DashboardUoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;

namespace Library.Controllers
{


    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardUnitOfWork _dashboardUnitOfWork;

        public DashboardController(IDashboardUnitOfWork dashboardUnitOfWork ,ICacheService cacheService)
        {
            _dashboardUnitOfWork = dashboardUnitOfWork;
        }

        // GET: api/<DashboardController>/Sales_Info/date
        [HttpGet("Sales_Info/{start_date}")]
        public async Task<ActionResult<DashBoardSalesInfo>> GetDashBoardSalesInfo(string start_date)
        {
          
            var dashBoardSalesInfo = await _dashboardUnitOfWork.GetDashboardSalesInfo(start_date);

            if (dashBoardSalesInfo == null)
                return NotFound("Dashboard Sales Info Not Found");

            return Ok(dashBoardSalesInfo);
        }

        // GET: api/<DashboardController>/TopEmployees
        [HttpGet("TopEmployees")]
        public async Task<ActionResult<IEnumerable<Name_Id_DTO>>> GetTopEmployees()
        {

            var namesAndIds = await _dashboardUnitOfWork.GetTopEmployees();

            if (namesAndIds.IsNullOrEmpty())
                return NotFound("Top Employees Info Not Found");

            return Ok(namesAndIds);
        }

        // GET: api/<DashboardController>/Sales_Chart_Info/date
        [HttpGet("Sales_Chart_Info/{start_date}")]
        public async Task<ActionResult<IEnumerable<SalesChartInfo>>> GetDashBoardSalesChartInfo(string start_date)
        {

            var dashBoardSalesChartInfo = await _dashboardUnitOfWork.GetDashBoardSalesChartInfo(start_date);

            if (dashBoardSalesChartInfo == null)
                return NotFound("Dashboard Sales Chart Info Not Found");

            return Ok(dashBoardSalesChartInfo);
        }

        // GET: api/<DashboardController>/Top_Book_Chart_Info/date
        [HttpGet("Top_Book_Chart_Info/{start_date}")]
        public async Task<ActionResult<IEnumerable<TopBooksChartInfo>>> GetTopBooksChartInfo(string start_date)
        {

            var topBooksChartInfo = await _dashboardUnitOfWork.GetTopBooksChartInfo(start_date);

            if (topBooksChartInfo == null)
                return NotFound("Dashboard Top Books Chart Info Not Found");

            return Ok(topBooksChartInfo);
        }
    }
}
