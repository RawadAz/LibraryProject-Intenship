using Library.Configurations.JwtUtils;
using Library.Data;
using Library.Models.Employee;
using Library.Repositories;
using Library.Repositories.EmployeeRepo;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Library.UnitsOfWork.EmployeeUoW
{
    public class EmployeeUnitOfWork : IEmployeeUnitOfWork
    {
        private readonly LibraryDBConnection _Connection;
        private readonly IJwtUtils _jwtUtils;

        public IEmployeeRepository EmployeeRepository { get; private set; }

        public EmployeeUnitOfWork(LibraryDBConnection connection, IJwtUtils jwtUtils)
        {
            _Connection = connection;
            EmployeeRepository = new EmployeeRepository(_Connection);
            _jwtUtils = jwtUtils;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            string query = "dbo.Get_All_Employees";
            return await EmployeeRepository.GetAllAsync(query);
        }

        public async Task<Employee?> GetEmployeeByID(int id)
        {
            if (id > 0)
            {
                string SqlQuery = $"dbo.Get_Employee_By_Id @id = {id};";
                return await EmployeeRepository.GetAsync(SqlQuery);
            }
            return null;
        }

        public async Task<int> InsertEmployee(Employee employee)
        {
            if (
                !employee.First_Name.IsNullOrEmpty() &&
                !employee.Last_Name.IsNullOrEmpty() &&
                employee.Branch_Id > 0 &&
                !employee.Dob.IsNullOrEmpty() &&
                !employee.Gender.IsNullOrEmpty() &&
                !employee.Phone_Number.IsNullOrEmpty() &&
                !employee.Username.IsNullOrEmpty() &&
                !employee.Password.IsNullOrEmpty() &&
                !employee.Position.IsNullOrEmpty() &&
                employee.Salary > 0
            )
            {
                string HashedPassword = Hashing.ToSHA256(employee.Password.ToLower());

                string query = $"dbo.Insert_Employee " +
                    $"@first_name = '{employee.First_Name.ToLower()}'," +
                    $" @last_name= '{employee.Last_Name.ToLower()}'," +
                    $" @branch_id = {employee.Branch_Id}," +
                    $" @DoB = '{employee.Dob}'," +
                    $" @gender = '{employee.Gender.ToLower()}'," +
                    $"@phone_number = '{employee.Phone_Number}'," +
                    $" @username = '{employee.Username}'," +
                    $" @password = '{HashedPassword}'," +
                    $" @position = '{employee.Position.ToLower()}'," +
                    $" @salary = {employee.Salary}," +
                    $" @supervisor_id = {employee.Supervisor_Id}";

                return await EmployeeRepository.InsertAsync(query);
            }
            return -1;
        }

        public async Task<int> UpdateEmployeeById(int id, Employee employee)
        {
            if (id > 0 &&
                !employee.First_Name.IsNullOrEmpty() &&
                !employee.Last_Name.IsNullOrEmpty() &&
                employee.Branch_Id > 0 &&
                !employee.Dob.IsNullOrEmpty() &&
                !employee.Gender.IsNullOrEmpty() &&
                !employee.Phone_Number.IsNullOrEmpty() &&
                !employee.Username.IsNullOrEmpty() &&
                !employee.Password.IsNullOrEmpty() &&
                !employee.Position.IsNullOrEmpty() &&
                employee.Salary > 0
                )
            {
                string HashedPassword = Hashing.ToSHA256(employee.Password.ToLower());

                string query = $"dbo.Update_Employee " +
                    $"@id = {id}," +
                    $" @first_name = '{employee.First_Name.ToLower()}'," +
                    $" @last_name= '{employee.Last_Name.ToLower()}'," +
                    $" @branch_id = {employee.Branch_Id}," +
                    $" @DoB = '{employee.Dob}'," +
                    $" @gender = '{employee.Gender.ToLower()}'," +
                    $" @phone_number = '{employee.Phone_Number}'," +
                    $" @username = '{employee.Username}'," +
                    $" @password = '{HashedPassword}'," +
                    $" @position = '{employee.Position.ToLower()}'," +
                    $" @salary = {employee.Salary}," +
                    $" @supervisor_id = {employee.Supervisor_Id}";

                return await EmployeeRepository.UpdateAsync(query);
            }
            return -1;
        }

        public async Task<int> DeleteEmployeeById(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Delete_Employee_By_Id @id = {id}";
                return await EmployeeRepository.DeleteAsync(query);
            }
            return 0;
        }

        public async Task<string> DeleteEmployeesByIds(List<int> ids)
        {
            string query = $"dbo.Delete_Employee_By_Id @id = ";
            return await EmployeeRepository.DeleteAllByIdsAsync(ids, query, "Employee");
        }

        public async Task<List<Employee>?> GetEmployeeByFullName(string first_name, string last_name)
        {
            if (!first_name.IsNullOrEmpty() && !last_name.IsNullOrEmpty())
            {
                string query = $"dbo.Get_Employee_By_Name @first_name = '{first_name.ToLower()}', @last_name = '{last_name.ToLower()}';";
                return await EmployeeRepository.GetAllAsync(query);
            }
            return null;
        }

        public async Task<int> UpdateEmployeePassword(PasswordUpdateDTO dto)
        {
            if (dto.OldPassword.Equals(dto.NewPassword))
            {
                return 2;
            }
            string HashedPassword = Hashing.ToSHA256(dto.NewPassword);
            string updatePassQuery = $"dbo.Change_Employee_Password @username = '{dto.Username}', @password = '{HashedPassword}';";
            string getPassQuery = $"dbo.Get_Employee_password_By_Username @username = '{dto.Username}'";

            return await EmployeeRepository.ChangePasswordAsync(getPassQuery, updatePassQuery, dto.OldPassword);

        }

        public async Task<LoginInfoDTO> GetEmployeeLoginInfo(string username, string password)
        {
            //hash password and get loginInfo
            string HashedPassword = Hashing.ToSHA256(password);
            string loginQuery = $"dbo.Check_Employee_Login_Info @username = '{username}', @password = '{HashedPassword}'";
            LoginInfoDTO employeeloginInfo =  await EmployeeRepository.GetLoginInfoAsync(loginQuery);
            
            var token = _jwtUtils.GenerateJwtToken(username, employeeloginInfo);

            employeeloginInfo.Token = token;

            return employeeloginInfo;

        }

        public async Task<IEnumerable<int>> GetAllManagerIds()
        {
            string query = "dbo.Get_All_Manager_Ids";

            return await EmployeeRepository.GetIdsAsync(query);
        }

        public async Task<IEnumerable<int>> GetAllEmployeeIds()
        {
            string query = "dbo.Get_All_Employee_Ids";

            return await EmployeeRepository.GetIdsAsync(query);
        }

        public async Task<Employee?> GetEmployeeByUsername(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                string SqlQuery = $"dbo.Get_Employee_By_Username @username = {username};";
                return await EmployeeRepository.GetAsync(SqlQuery);
            }
            return null;
        }
    }
}
