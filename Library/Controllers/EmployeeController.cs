using Library.Configurations.CacheService;
using Library.Models.Employee;
using Library.Models.Employee.DTO_s;
using Library.UnitsOfWork.EmployeeUoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeUnitOfWork _employeeUnitOfWork;
        private readonly ICacheService _cacheService;

        public EmployeeController(IEmployeeUnitOfWork employeeUnitOfWork, ICacheService cacheService)
        {
            _employeeUnitOfWork = employeeUnitOfWork;
            _cacheService = cacheService;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetAllEmployees()
        {
            //checking cache
            var EmployeeCache = _cacheService.GetData<IEnumerable<Employee>>("Employees");

            if (!EmployeeCache.IsNullOrEmpty())
                return Ok(EmployeeCache);

            var employees = await _employeeUnitOfWork.GetAllEmployees();

            if (employees.IsNullOrEmpty())
                return NotFound("No Employees Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<Employee>>("Employees", employees, cacheExpiry);

            return Ok(employees);
        }

        // GET: api/<EmployeeController>/ManagerIds
        [HttpGet("Manager_Ids")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<int>>> GetAllManagerIds()
        {
            //checking cache
            var EmployeeCache = _cacheService.GetData<IEnumerable<int>>("ManagerIds");

            if (!EmployeeCache.IsNullOrEmpty())
                return Ok(EmployeeCache);

            var ids = await _employeeUnitOfWork.GetAllManagerIds();

            if (ids.IsNullOrEmpty())
                return NotFound("No Managers Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<int>>("ManagerIds", ids, cacheExpiry);

            return Ok(ids);
        }

        // GET: api/<EmployeeController>/Employee_Ids
        [HttpGet("Employee_Ids")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<int>>> GetAllEmployeeIds()
        {
            //checking cache
            var EmployeeCache = _cacheService.GetData<IEnumerable<int>>("EmployeeIds");

            if (!EmployeeCache.IsNullOrEmpty())
                return Ok(EmployeeCache);

            var ids = await _employeeUnitOfWork.GetAllEmployeeIds();

            if (ids.IsNullOrEmpty())
                return NotFound("No Employees Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<int>>("EmployeeIds", ids, cacheExpiry);

            return Ok(ids);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployeeById(int id)
        {
            //checking cache
            var EmloyeeCache = _cacheService.GetData<Employee>($"employee{id}");

            if (EmloyeeCache != null)
                return Ok(EmloyeeCache);

            var employee = await _employeeUnitOfWork.GetEmployeeByID(id);
            

            if (employee == null)
                return NotFound("Invalid Id");

            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"employee{id}", employee, cacheExpiry);

            return Ok(employee);
        }

        //GET api/<EmployeeController/Name
        [HttpGet("Employee_Name")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetEmployeeByFullName(string first_name, string last_name)
        {
            var EmployeeCache = _cacheService.GetData<IEnumerable<Employee>>($"employee{first_name}_{last_name}");

            if (!EmployeeCache.IsNullOrEmpty())
                return Ok(EmployeeCache);

            var employees = await _employeeUnitOfWork.GetEmployeeByFullName(first_name, last_name);

            if (employees.IsNullOrEmpty())
                return NotFound("Employee Not Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"employee{first_name}_{last_name}", employees, cacheExpiry);

            return Ok(employees);
        }

        //GET api/<EmployeeController/Username
        [HttpGet("Username")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployeeByUsername(string Username)
        {
            var EmployeeCache = _cacheService.GetData<Employee>($"employee{Username}");

            if (EmployeeCache != null)
                return Ok(EmployeeCache);

            var employee = await _employeeUnitOfWork.GetEmployeeByUsername(Username);

            if (employee == null)
                return NotFound("Employee Not Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"employee{Username}", employee, cacheExpiry);

            return Ok(employee);
        }

        //Put api/<EmployeeController/Password
        [HttpPut("Password")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> UpdateEmployeePassword(PasswordUpdateDTO dto)
        {
            var result = await _employeeUnitOfWork.UpdateEmployeePassword(dto);

            return result switch
            {
                1 => Ok("Password Updated Successfully"),
                2 => BadRequest("old and new password can't be the same"),
                3 => NotFound("Invalid username"),
                4 => BadRequest("Incorrect old password, try again"),
                _ => StatusCode(500, "Something went wrong please try again"),
            };
        }

        // POST api/<EmployeeController>
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> InsertEmployee(Employee employee)
        {

            int affected_rows = await _employeeUnitOfWork.InsertEmployee(employee);

            if (affected_rows > 0)
            {

                //removing invalid cache
                _cacheService.RemoveData("Employees"); 
                _cacheService.RemoveData("EmployeeIds");
                _cacheService.RemoveData("ManagerIds");

                return Ok("Employee Inserted Successfully");
            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            else
                throw new Exception("Insertion failed, Try agian");
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
        {
            var affected_rows = await _employeeUnitOfWork.UpdateEmployeeById(id, employee);

            if (affected_rows > 0)
            {

                var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);

                //Removing invalid cache
                _cacheService.RemoveData("Employees");

                //updating cache
                _cacheService.SetData($"employee{id}", employee, cacheExpiry);
   
                return Ok("Employee updated successfully");

            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            return NotFound("Employee Not Found! Check id and try again");
        }
        
        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            int affected_rows = await _employeeUnitOfWork.DeleteEmployeeById(id);

            if (affected_rows > 0)
            {
                //removing invalid cache
                _cacheService.RemoveData($"employee{id}");
                _cacheService.RemoveData("Employees");
                _cacheService.RemoveData("EmployeeIds");
                _cacheService.RemoveData("ManagerIds");

                return Ok("Employee Deleted Successfully");
            }
            return NotFound("Employee with id: " + id + " does not exists");
        }

        // DELETE api/<EmployeeController>/Multiple
        [HttpDelete("Multiple")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> DeleteMultipleEmployeesByIds(List<int> ids)
        {
            string result = await _employeeUnitOfWork.DeleteEmployeesByIds(ids);

            //removing invalid cache

            _cacheService.RemoveData("Employees");
            _cacheService.RemoveData("EmployeeIds");
            _cacheService.RemoveData("ManagerIds");

            foreach (int id in ids)
            {
                _cacheService.RemoveData($"employee{id}");
            }
            
            return Ok(result);
        }

        //Post api/<EmployeeController>/LogIn
        [HttpPost("Login")]
        public async Task<ActionResult<LoginInfoDTO>> EmployeeLogin(LoginRequestDTO dto)
        {
            if (dto.Username.IsNullOrEmpty())
                return BadRequest("Username required");
            if(dto.Password.IsNullOrEmpty())
                return BadRequest("Password required");

            var loginInfo = await _employeeUnitOfWork.GetEmployeeLoginInfo(dto.Username, dto.Password);

            if(loginInfo == null)
                return BadRequest("username or password incorrect, try again");

            return Ok(loginInfo);
        }
    }
}
