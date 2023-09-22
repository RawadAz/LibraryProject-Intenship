using Library.Models.Event;
using Library.Models.Event.DTO;
using Library.Models.NameAndIdDTO;
using Library.Repositories;

namespace Library.UnitsOfWork.EventUoW
{
    public interface IEventUnitOfWork
    {
        IEventRepository EventRepository { get; }

        Task<List<EventDTO>> GetAllEvents();
        Task<EventDTO?> GetEventByID(int id);
        Task<int> InsertEvent(Event @event);
        Task<int> UpdateEventById(int id, Event @event);
        Task<int> DeleteEventById(int id);
        Task<int> UpdateEventSeats(int id, int event_Seats);
        Task<List<Name_Id_DTO>> GetEventIdsAndNames();
        Task<List<string>> GetEventNamesByBranch(int branchId);
        Task<List<int>> GetEventAvaialbleSeatsById(int id);
    }
}
