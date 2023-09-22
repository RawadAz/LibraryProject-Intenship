using Library.Models.Branch;
using Library.Models.NameAndIdDTO;
using Library.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Library.UnitsOfWork.BranchUoW
{
    public interface IBranchUnitOfWork
    {
        IBranchRepository BranchRepository { get; }


        Task<List<Branch>> GetAllBranches();
        Task<Branch?> GetBranchByID(int id);
        Task<int> InsertBranch(Branch branch);
        Task<int> UpdateBranchManagerById(int id, BranchUpdateDTO dto);
        Task<int> DeleteBranchById(int id);
        Task<List<BranchLocationDTO>?> GetBranchLocation();
        Task<List<int>> GetAllBranchesIds();
        Task<List<string>> GetAllBranchNames();
        Task<List<Name_Id_DTO>> GetBranchIdsAndNames();


    }
}
