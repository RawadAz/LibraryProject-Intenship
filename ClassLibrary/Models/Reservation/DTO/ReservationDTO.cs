namespace ClassLibrary.Models.Reservation.DTO
{
    public class ReservationDTO
    {
        public int Event_Id { get; set; }
        public string Event { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public string Client_Name { get; set; } = string.Empty;
        public string Client_Phone_Number { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public double Fee { get; set; }
        public int Nb_Of_Tickets { get; set; }
        public double Total_Fee { get; set; }
    }
}
