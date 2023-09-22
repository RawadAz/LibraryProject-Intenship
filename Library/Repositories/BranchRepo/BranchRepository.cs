using Dapper;
using Library.Data;
using Library.Models.Branch;
using Library.Models.NameAndIdDTO;
using Library.Repositories.GenericRepo;

namespace Library.Repositories.BranchRepo
{
    public class BranchRepository : GenericRepository<Branch>, IBranchRepository
    {
        private new readonly LibraryDBConnection _Connection;

        public IGenericRepository<Branch> GenericRepository { get; private set; }
        public BranchRepository(LibraryDBConnection connection) : base(connection) 
        {
            _Connection = connection;
            GenericRepository = new GenericRepository<Branch>(_Connection);
        }

        public async Task<List<BranchLocationDTO>> GetBranchLocationsAsync(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<BranchLocationDTO>(query)).ToList();
        }

        public async Task<List<int>> GetBranchesIdsAsync(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<int>(query)).ToList();
        }

        public async Task<List<string>> GetBranchNamesAsync(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<string>(query)).ToList();
        }

        public async Task<List<Name_Id_DTO>> GetBookIdsAndNames(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<Name_Id_DTO>(query)).ToList(); ;
        }
    }
}
