using Library.Data;
using Library.Models.Event;
using Library.Models.Event.DTO;
using Library.Models.NameAndIdDTO;
using Library.Repositories;
using Library.Repositories.EventRepo;
using Microsoft.IdentityModel.Tokens;

namespace Library.UnitsOfWork.EventUoW
{
    public class EventUnitOfWork : IEventUnitOfWork
    {

        private readonly LibraryDBConnection _Connection;

        public IEventRepository EventRepository { get; private set; }

        public EventUnitOfWork(LibraryDBConnection connection)
        {
            _Connection = connection;

            EventRepository = new EventRepository(_Connection);
        }

        public async Task<List<EventDTO>> GetAllEvents()
        {
            string query = "dbo.Get_All_Events;";
            return await EventRepository.GetAllAsync(query);
        }

        public async Task<EventDTO?> GetEventByID(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Get_Event_By_Id @id = {id}";
                return await EventRepository.GetAsync(query);
            }
            return null;
        }

        public async Task<int> InsertEvent(Event @event)
        {
            if (
               !@event.Name.IsNullOrEmpty() &&
               !@event.Date.IsNullOrEmpty() &&
               @event.Branch_id > 0 &&
               @event.Available_seats > 0 &&
               @event.Fee > 0 &&
               !@event.Recurrence.IsNullOrEmpty() &&
               !@event.Description.IsNullOrEmpty()
           )
            {

                string query = $"dbo.Insert_Event" +
                    $" @name = '{@event.Name.ToLower()}'," +
                    $" @date = '{@event.Date}'," +
                    $" @branch_id = {@event.Branch_id}," +
                    $" @available_seats = {@event.Available_seats}," +
                    $" @fee = {@event.Fee}," +
                    $" @recurrence = '{@event.Recurrence.ToLower()}'," +
                    $" @description = '{@event.Description.ToLower()}';";

                return await EventRepository.InsertAsync(query);
            }
            return -1;
        }

        public async Task<int> UpdateEventById(int id, Event @event)
        {
            if (id > 0 &&
                !@event.Name.IsNullOrEmpty() &&
               !@event.Date.IsNullOrEmpty() &&
               @event.Branch_id > 0 &&
               @event.Available_seats > 0 &&
               @event.Fee > 0 &&
               !@event.Recurrence.IsNullOrEmpty() &&
               !@event.Description.IsNullOrEmpty()
                )
            {

                string query = $"dbo.Update_Event" +
                    $" @id = {id}," +
                    $" @name = '{@event.Name.ToLower()}'," +
                    $" @date = '{@event.Date}'," +
                    $" @branch_id = {@event.Branch_id}," +
                    $" @available_seats = {@event.Available_seats}," +
                    $" @fee = {@event.Fee}," +
                    $" @recurrence = '{@event.Recurrence.ToLower()}'," +
                    $" @description = '{@event.Description.ToLower()}';";

                return await EventRepository.UpdateAsync(query);
            }
            return -1;
        }

        public async Task<int> DeleteEventById(int id)
        {
            if (id > 0)
            {
                string query = $"dbo.Delete_Event_By_Id @id = {id}";
                return await EventRepository.DeleteAsync(query);
            }
            return 0;
        }

        public async Task<int> UpdateEventSeats(int id, int event_Seats)
        {
            if (id > 0 && event_Seats > 0)
            {
                string query = $"dbo.Update_Event_Available_Seats @id = {id}, @available_seats = {event_Seats};";
                return await EventRepository.UpdateAsync(query);
            }
            return 0;
        }

        public async Task<List<Name_Id_DTO>> GetEventIdsAndNames()
        {
            string query = "dbo.Get_Events_Ids_And_Names";
            return await EventRepository.GetEventIdsAndNames(query);
        }

        public async Task<List<string>> GetEventNamesByBranch(int branchId)
        {
            string query = $"dbo.Get_Event_Names_By_Branch @branch_Id = {branchId}";
            return await EventRepository.GetEventNamesByBranch(query);
        }

        public async Task<List<int>> GetEventAvaialbleSeatsById(int id)
        {
            string query = $"dbo.Get_Event_Available_Seats @event_id = {id}";
            return await EventRepository.GetEventAvaialbleSeatsById(query);
        }
    }
}
