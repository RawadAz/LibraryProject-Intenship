namespace ClassLibrary.Models.Reservation.DTO
{
    public class EditReservationDTO
    {
        public string Client_Phone_Number { get; set; } = string.Empty;
        public int Event_Id { get; set; }
        public int Nb_Of_Tickets { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is EditReservationDTO dTO &&
                   Client_Phone_Number == dTO.Client_Phone_Number &&
                   Event_Id == dTO.Event_Id &&
                   Nb_Of_Tickets == dTO.Nb_Of_Tickets;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Client_Phone_Number, Event_Id, Nb_Of_Tickets);
        }
    }
}
