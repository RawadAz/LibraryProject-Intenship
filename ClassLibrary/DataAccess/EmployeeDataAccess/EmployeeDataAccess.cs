using ClassLibrary.HttpClients.EmployeeHC;
using ClassLibrary.JwtToken;
using ClassLibrary.Models.Employee;
using ClassLibrary.Models.Employee.DTO_s;
using ClassLibrary.Models.Employee.DTO_s.LoginInfo;
using ClassLibrary.Models.Employee.DTO_s.PasswordUpdate;
using System.Text;
using System.Text.Json;

namespace ClassLibrary.DataAccess.EmployeeDataAccess
{
    public class EmployeeDataAccess
    {
        private readonly EmployeeHttpClient _EmployeeHttpClient;
        private readonly string _url = "/Employee";

        public EmployeeDataAccess()
        {
            _EmployeeHttpClient = new EmployeeHttpClient();
        }

        public async Task<LoginInfoResponseDTO?> GetLoginInfo(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
                throw new Exception("Username is required");

            if (string.IsNullOrEmpty(password))
                throw new Exception("Password is required");

            LoginInfoRequestDTO requestDTO = new()
            {
                Username = username,
                Password = password
            };


            return await _EmployeeHttpClient.GetLoginInfo(requestDTO);

        }

        public async Task<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            return await _EmployeeHttpClient.GetAll(_url);
        }

        public async Task<EmployeeDTO> GetEmployeeById(string? IdText)
        {
            if (string.IsNullOrEmpty(IdText))
            {
                throw new Exception("Id is required");
            }

            bool parsed = int.TryParse(IdText, out int id);

            if (!parsed)
            {
                throw new Exception("Id should be a number");
            }

            string url = _url + $"/{id}";

            return await _EmployeeHttpClient.Get(url);
        }

        public async Task<IEnumerable<EmployeeDTO>> GetEmployeeByName(string firstName, string lastName)
        {
            if (firstName == null || firstName == string.Empty)
                throw new Exception("First name is required");

            if (lastName == null || lastName == string.Empty)
                throw new Exception("Last name is required");

            var url = _url + $"/Employee_Name?first_name={firstName}&last_name={lastName}";

            return await _EmployeeHttpClient.GetAll(url);

        }

        public async Task<string> AddEmployee(Employee employee)
        {
            var serializedEmployee = JsonSerializer.Serialize(employee);
            var requestContent = new StringContent(serializedEmployee, Encoding.UTF8, "application/json");

            return await _EmployeeHttpClient.Add(_url, requestContent);
        }

        public async Task<IEnumerable<int>> GetSupervisorIds()
        {
            IEnumerable<int> ids = await _EmployeeHttpClient.GetManagerIds();
            if (ids.Any())
            {
                return ids;
            }
            else
                throw new Exception("Managers ids not found");
        }

        public async Task<IEnumerable<int>> GetEmployeeIds()
        {
            IEnumerable<int> ids = await _EmployeeHttpClient.GetEmployeeIds();
            if (ids.Any())
            {
                return ids;
            }
            else
                throw new Exception("Employee ids not found");
        }

        public async Task<string> UpdateEmployee(Employee employee)
        {
            string url = _url + $"/{employee.Id}";

            var serializedEmployee = JsonSerializer.Serialize(employee);
            var requestContent = new StringContent(serializedEmployee, Encoding.UTF8, "application/json");

            return await _EmployeeHttpClient.Update(url, requestContent);
        }

        public async Task<EmployeeDTO?> GetEmployeeByUsername(string username)
        {

            if (string.IsNullOrEmpty(username))
                throw new Exception("Username is missing, try restarting the app");

            string url = _url + $"/Username?username={username}";

            EmployeeDTO employee = await _EmployeeHttpClient.Get(url);

            if (employee == null)
                throw new Exception("Employee Not found, try refreshing the app");

            return employee;
        }

        public async Task<string> DeleteEmployee(int id)
        {
            string url = _url + $"/{id}";

            return await _EmployeeHttpClient.Delete(url);
        }

        public async Task<string> DeleteMultipleEmployees(List<int> idsToBeDeleted)
        {
            return await _EmployeeHttpClient.DeleteMultipleEmployees(idsToBeDeleted);
        }

        public async Task<string> UpdatePassword(string username, string oldPassword, string newPassword, string confirmPassword)
        {

            if (string.IsNullOrEmpty(username))
                throw new Exception("Username is required");
            if (string.IsNullOrEmpty(oldPassword))
                throw new Exception("Old password is required");
            if (string.IsNullOrEmpty(newPassword))
                throw new Exception("New password is required");
            if (string.IsNullOrEmpty(confirmPassword))
                throw new Exception("Password confirmation is required");
            if (!newPassword.Equals(confirmPassword))
                throw new Exception("New password and confirmation password did not match");
            if (oldPassword.Equals(newPassword))
                throw new Exception("New password can't be the same as your old one");

            PasswordUpdateDTO dto = new()
            {
                Username = username,
                OldPassword = oldPassword,
                NewPassword = newPassword
            };

            return await _EmployeeHttpClient.UpdatePassword(dto);
        }
    }
}
