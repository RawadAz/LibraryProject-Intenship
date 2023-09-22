using Dapper;
using Library.Data;
using Library.Models;
using Library.Repositories.ClientRepo;
using LiteDB;
using System.Transactions;

namespace Library.Repositories.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected LibraryDBConnection _Connection;

        public GenericRepository(LibraryDBConnection Connection)
        {
            _Connection = Connection;
        }

        public async Task<List<T>> GetAllAsync(string query)
        {
            using (var connection = _Connection.GetConnection())
            {
                return (await connection.QueryAsync<T>(query)).ToList();
            }
        }

        public async Task<T> GetAsync(string query)
        {

            using (var connection = _Connection.GetConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<T>(query); 
            }
        }

        public async Task<int> DeleteAsync(string query)
        {
            
            using (var connection = _Connection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var QueryResult = await connection.ExecuteAsync(query, transaction: transaction);
                        transaction.Commit();
                        connection.Close();
                        return QueryResult;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        connection.Close();
                        throw;
                    }
                }
            }
        }

        public async Task<int> InsertAsync(string query)
        {
            using (var connection = _Connection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var QueryResult = await connection.ExecuteAsync(query, transaction: transaction);
                        transaction.Commit();
                        connection.Close();
                        return QueryResult;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        connection.Close();
                        throw;
                    }
                }
            }
        }

        public async Task<int> UpdateAsync(string query)
        {
            using (var connection = _Connection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var QueryResult = await connection.ExecuteAsync(query, transaction: transaction);

                        transaction.Commit();
                        connection.Close();
                        return QueryResult;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        connection.Close();
                        throw;
                    }
                }
            }
        }

        public async Task<string> DeleteAllByIdsAsync(List<int> ids, string query, string to_be_deleted)
        {
            string result = "";
            
            using (var connection = _Connection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    foreach (int id in ids)
                    {
                        string SqlQuery = query + id;
                        try
                        {
                            var QueryResult = await connection.ExecuteAsync(SqlQuery, transaction: transaction);

                            if (QueryResult == 0)
                                result += $"{to_be_deleted} with id = {id} was not found\n";
                            if (QueryResult == 1)
                                result += $"{to_be_deleted} with id = {id} was deleted successfully\n";
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            connection.Close();
                            throw;
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                }
            }
            return result;
        }
    }
}
