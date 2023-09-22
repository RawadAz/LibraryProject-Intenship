using Library.Data;
using Library.Models.Branch;
using Library.Models.NameAndIdDTO;
using Library.Repositories;
using Library.Repositories.BookRepo;
using Library.Repositories.BranchRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.IdentityModel.Tokens;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library.UnitsOfWork.BranchUoW
{
    public class BranchUnitOfWork : IBranchUnitOfWork
    {
        private readonly LibraryDBConnection _Connection;

        public IBranchRepository BranchRepository { get; private set; }

        public BranchUnitOfWork(LibraryDBConnection connection)
        {
            _Connection = connection;
            BranchRepository = new BranchRepository(_Connection);
        }

        //Branch Methods

        public async Task<List<Branch>> GetAllBranches()
        {
            string query = "dbo.Get_All_Branches";
            return await BranchRepository.GetAllAsync(query);
        }

        public async Task<Branch?> GetBranchByID(int id)
        {
            if (id > 0)
            {
                string SqlQuery = $"dbo.Get_Branch_By_Id @id = {id};";
                return await BranchRepository.GetAsync(SqlQuery);
            }
            return null;
        }

        public async Task<int> InsertBranch(Branch branch)
        {
            if (
                !branch.Name.IsNullOrEmpty() &&
                !branch.Location.IsNullOrEmpty() &&
                branch.Manager_Id > 0 &&
                branch.Manager_Start_Date != null
            )
            {

                string query = $"dbo.Insert_Branch" +
                    $" @name = '{branch.Name.ToLower()}'," +
                    $" @Location = '{branch.Location.ToLower()}'," +
                    $" @manager_id = {branch.Manager_Id}," +
                    $" @manager_start_date = '{branch.Manager_Start_Date}';";

                return await BranchRepository.InsertAsync(query);
            }
            return -1;
        }

        public async Task<int> UpdateBranchManagerById(int id, BranchUpdateDTO dto)
        {
            if (id > 0 &&
                !dto.Name.IsNullOrEmpty() &&
                !dto.Location.IsNullOrEmpty() &&
                dto.CurrentManagerId > 0 &&
                dto.NewManagerId > 0 &&
                !dto.ManagerStartDate.IsNullOrEmpty()
                )
            {
                string query = $"dbo.Update_Branch_By_Id" +
                    $" @id = {id}," +
                    $" @name = '{dto.Name.ToLower()}'," +
                    $" @Location = '{dto.Location.ToLower()}'," +
                    $" @current_manager_id = {dto.CurrentManagerId}," +
                    $" @new_manager_id = {dto.NewManagerId}," +
                    $" @manager_start_date = '{dto.ManagerStartDate}';";

                return await BranchRepository.UpdateAsync(query);
            }
            return -1;
        }

        public async Task<int> DeleteBranchById(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Delete_Branch_By_Id @id = {id}";
                return await BranchRepository.DeleteAsync(query);
            }
            return 0;
        }

        public async Task<List<BranchLocationDTO>?> GetBranchLocation()
        {
            string query = $"dbo.Get_Branch_Locations";
            var branchLocations = await BranchRepository.GetBranchLocationsAsync(query);
            return branchLocations;
        }

        public async Task<List<int>> GetAllBranchesIds()
        {
            string query = $"dbo.Get_All_Branches_Ids";

            return await BranchRepository.GetBranchesIdsAsync(query);
        }

        public async Task<List<string>> GetAllBranchNames()
        {
            string query = $"dbo.Get_Branch_Names";

            return await BranchRepository.GetBranchNamesAsync(query);
        }

        public async Task<List<Name_Id_DTO>> GetBranchIdsAndNames()
        {
            string query = $"dbo.Get_Branch_Ids_And_Names";
            return await BranchRepository.GetBookIdsAndNames(query);
        }
    }
}
