namespace ClassLibrary.Models.Reservation.DTO;

public class DeleteReservationDTO
{
    public int Event_Id { get; set; }
    public string Client_Phone_Number { get; set; } = string.Empty;
}
