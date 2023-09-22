using Library.Models.Reservation.DTO_s;
using Library.Repositories;

namespace Library.UnitsOfWork.ReservationUoW
{
    public interface IReservationUnitOfWork
    {
        IReservationRepository ReservationRepository { get; }


        Task<IEnumerable<ReservationDTO>> GetAllReservations();
        Task<IEnumerable<ReservationDTO>> GetReservationByClientPhoneNumber(int client_phone_number);
        Task<IEnumerable<ReservationDTO>?> GetReservationByEvent(string event_Name, string branch_Name);
        Task<int> InsertReservation(EditReservationDTO editReservationDTO);
        Task<int> UpdateReservation(EditReservationDTO dto);
        Task<int> DeleteReservation(DeleteReservationDTO dto);
    }
}
