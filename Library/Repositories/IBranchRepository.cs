using Library.Models.Branch;
using Library.Models.NameAndIdDTO;
using Microsoft.AspNetCore.Mvc;

namespace Library.Repositories
{
    public interface IBranchRepository : IGenericRepository<Branch>
    {
        Task<List<Name_Id_DTO>> GetBookIdsAndNames(string query);
        Task<List<int>> GetBranchesIdsAsync(string query);
        Task<List<BranchLocationDTO>> GetBranchLocationsAsync(string query);
        Task<List<string>> GetBranchNamesAsync(string query);
    }
}
