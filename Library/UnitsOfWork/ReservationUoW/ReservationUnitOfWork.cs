using Library.Data;
using Library.Models.Reservation.DTO_s;
using Library.Repositories;
using Library.Repositories.ReservationRepo;
using Microsoft.IdentityModel.Tokens;

namespace Library.UnitsOfWork.ReservationUoW
{
    public class ReservationUnitOfWork : IReservationUnitOfWork
    {
        private readonly LibraryDBConnection _Connection;

        public IReservationRepository ReservationRepository { get; private set; }

        public ReservationUnitOfWork(LibraryDBConnection connection)
        {
            _Connection = connection;
            ReservationRepository = new ReservationRepository(_Connection);
        }

        //Reservation Methods:

        public async Task<IEnumerable<ReservationDTO>> GetAllReservations()
        {
            string query = "dbo.Get_All_Reservations;";
            return await ReservationRepository.GetAllAsync(query);
        }

        public async Task<IEnumerable<ReservationDTO>> GetReservationByClientPhoneNumber(int client_phone_number)
        {
            string query = $"dbo.Get_Reservations_By_Client @client_phone_number = '{client_phone_number}';";
            return await ReservationRepository.GetAllAsync(query);
        }

        public async Task<IEnumerable<ReservationDTO>?> GetReservationByEvent(string event_Name, string branch_Name)
        {
            if (event_Name.IsNullOrEmpty() || branch_Name.IsNullOrEmpty())
                return null;

            string query = $"dbo.Get_Reservations_By_Event @event_name = '{event_Name}', @branch_name = '{branch_Name}';";
            return await ReservationRepository.GetAllAsync(query);
        }

        public async Task<int> InsertReservation(EditReservationDTO dto)
        {
            if (
              dto.Event_Id > 0 &&
              !dto.Client_Phone_Number.IsNullOrEmpty() &&
              dto.Nb_Of_Tickets > 0
            )
            {

                string query = $"dbo.INSERT_Reservation" +
                    $" @client_phone_number = '{dto.Client_Phone_Number}'," +
                    $" @event_id = {dto.Event_Id}," +
                    $" @nb_of_tickets = {dto.Nb_Of_Tickets};";

                return await ReservationRepository.InsertAsync(query);
            }
            return -1;
        }

        public async Task<int> UpdateReservation(EditReservationDTO dto)
        {
            if (
               dto.Event_Id > 0 &&
               !dto.Client_Phone_Number.IsNullOrEmpty() &&
               dto.Nb_Of_Tickets > 0
             )
            {

                string query = $"dbo.Update_Reservation_Nb_Of_Tickets" +
                    $" @client_phone_number = '{dto.Client_Phone_Number}'," +
                    $" @event_id = {dto.Event_Id}," +
                    $" @nb_of_tickets = {dto.Nb_Of_Tickets};";

                return await ReservationRepository.UpdateAsync(query);
            }
            return -1;
        }

        public async Task<int> DeleteReservation(DeleteReservationDTO dto)
        {
            if (
                !dto.Client_Phone_Number.IsNullOrEmpty() &&
                dto.Event_Id > 0
                )
            {
                string query = $"dbo.Delete_Reservation" +
                    $" @event_id = {dto.Event_Id}," +
                    $" @client_phone_number = '{dto.Client_Phone_Number}'";

                return await ReservationRepository.DeleteAsync(query);
            }
            return 0;
        }
    }
}
