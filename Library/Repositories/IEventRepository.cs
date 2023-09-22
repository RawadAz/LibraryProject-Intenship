using Library.Models.Event;
using Library.Models.Event.DTO;
using Library.Models.NameAndIdDTO;

namespace Library.Repositories
{
    public interface IEventRepository : IGenericRepository<EventDTO>
    {
        Task<List<int>> GetEventAvaialbleSeatsById(string query);
        Task<List<Name_Id_DTO>> GetEventIdsAndNames(string query);
        Task<List<string>> GetEventNamesByBranch(string query);
    }
}
