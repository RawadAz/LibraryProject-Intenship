namespace Library.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(string query);
        Task<T> GetAsync(string query);
        Task<int> DeleteAsync(string query);
        Task<int> InsertAsync(string query);
        Task<int> UpdateAsync(string query);
        Task<string> DeleteAllByIdsAsync(List<int> ids, string query ,string to_be_deleted);
    }
}
