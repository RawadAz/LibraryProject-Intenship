using ClassLibrary.HttpClients.branchHC;
using ClassLibrary.Models.IdAndNameDTO;
using ClassLibrary.Models.Branch;
using ClassLibrary.HttpClients.BookHC;
using ClassLibrary.Models.Book;
using ClassLibrary.Models.Branch.DTO;
using System.Text;
using System.Text.Json;
using System.Security.Policy;

namespace ClassLibrary.DataAccess.BranchDataAccess
{
    public class BranchDataAccess
    {
        private readonly BranchHttpClient _branchHttpClient;
        private readonly string _url = "/Branch";

        public BranchDataAccess()
        {
            _branchHttpClient = new BranchHttpClient();
        }

        public async Task<IEnumerable<int>> GetBranchIds()
        {
            IEnumerable<int> ids = await _branchHttpClient.GetBranchIds();
            if (ids.Any())
            {
                return ids;
            }
            else
                throw new Exception("Branches ids not found");
        }

        public async Task<IEnumerable<string>> GetBranchNames()
        {
            IEnumerable<string> names = await _branchHttpClient.GetBranchNames();
            if (names.Any())
            {
                return names;
            }
            else
                throw new Exception("Branches names not found");
        }

        public async Task<IEnumerable<NameAndIdDTO>> GetBranchIdsAndNames()
        {
            return await _branchHttpClient.GetBranchIdsAndNames();
        }

        public async Task<Branch> GetBranchById(int id)
        {
            if (id < 0)
                throw new Exception("Invalid branch Id");

            string url = _url + $"/{id}";

            return await _branchHttpClient.Get(url);
        }

        public async Task<IEnumerable<Branch>> GetAllBranches()
        {
            return await _branchHttpClient.GetAll(_url);
        }

        public async Task<string> AddBranch(Branch branch)
        {
            var serializedBranch = JsonSerializer.Serialize(branch);
            var requestContent = new StringContent(serializedBranch, Encoding.UTF8, "application/json");

            return await _branchHttpClient.Add(_url, requestContent);
        }

        public async Task<string> DeleteBranch(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid branch Id");

            string url = _url + $"/{id}";

            return await _branchHttpClient.Delete(url);
        }

        public async Task<string> UpdateBranch(BranchUpdateDTO branch)
        {
            string url = _url + $"/{branch.Id}";

            var serializedBranch = JsonSerializer.Serialize(branch);
            var requestContent = new StringContent(serializedBranch, Encoding.UTF8, "application/json");

            return await _branchHttpClient.Update(url, requestContent);
        }

        public async Task<IEnumerable<BranchLocationDTO>> GetBranchLocations()
        {
            return await _branchHttpClient.GetBranchLocations();
        }
    }
}
