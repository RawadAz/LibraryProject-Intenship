namespace Library.Models.Reservation.DTO_s
{
    public class EditReservationDTO
    {
        public string Client_Phone_Number { get; set; } = string.Empty;
        public int Event_Id { get; set; }
        public int Nb_Of_Tickets { get; set; }
    }
}
