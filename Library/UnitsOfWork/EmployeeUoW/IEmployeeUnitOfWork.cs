using Library.Models.Employee;
using Library.Repositories;

namespace Library.UnitsOfWork.EmployeeUoW
{
    public interface IEmployeeUnitOfWork 
    {
        IEmployeeRepository EmployeeRepository { get; }

        Task<List<Employee>> GetAllEmployees();
        Task<Employee?> GetEmployeeByID(int id);
        Task<Employee?> GetEmployeeByUsername(string username);
        Task<List<Employee>?> GetEmployeeByFullName(string first_name, string last_name);
        Task<int> InsertEmployee(Employee employee);
        Task<int> UpdateEmployeePassword(PasswordUpdateDTO dto);
        Task<int> UpdateEmployeeById(int id, Employee employee);
        Task<int> DeleteEmployeeById(int id);
        Task<string> DeleteEmployeesByIds(List<int> ids);
        Task<LoginInfoDTO> GetEmployeeLoginInfo(string username, string password);
        Task<IEnumerable<int>> GetAllManagerIds();
        Task<IEnumerable<int>> GetAllEmployeeIds();
        
    }
}
