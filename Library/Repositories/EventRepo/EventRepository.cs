using Dapper;
using Library.Data;
using Library.Models.Event;
using Library.Models.Event.DTO;
using Library.Models.NameAndIdDTO;
using Library.Repositories.GenericRepo;

namespace Library.Repositories.EventRepo
{
    public class EventRepository : GenericRepository<EventDTO>, IEventRepository
    {
        private new readonly LibraryDBConnection _Connection;

        public IGenericRepository<EventDTO> GenericRepository { get; private set; }
        
        public EventRepository(LibraryDBConnection connection) : base(connection) 
        {
            _Connection = connection;
            GenericRepository = new GenericRepository<EventDTO>(_Connection);
        }

        public async Task<List<Name_Id_DTO>> GetEventIdsAndNames(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<Name_Id_DTO>(query)).ToList();
        }

        public async Task<List<string>> GetEventNamesByBranch(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<string>(query)).ToList();
        }

        public async Task<List<int>> GetEventAvaialbleSeatsById(string query)
        {
            using var connection = _Connection.GetConnection();
            return (await connection.QueryAsync<int>(query)).ToList();
        }
    }
}
