using Library.Models.Employee;

namespace Library.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<int> ChangePasswordAsync(string getPassQuery, string updatePassQuery, string old_password);
        Task<LoginInfoDTO> GetLoginInfoAsync(string query);
        Task<IEnumerable<int>> GetIdsAsync(string query);
    }
}
