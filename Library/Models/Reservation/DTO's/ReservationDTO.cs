namespace Library.Models.Reservation.DTO_s
{
    public class ReservationDTO
    {
        public int Event_Id { get; set; }
        public string Event { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public string Client_Name { get; set; } = string.Empty;
        public string Client_Phone_Number { get; set; } = string.Empty;

        private string date = string.Empty;
        public string Date
        {
            get
            {
                bool conversion = DateOnly.TryParseExact(date, "MM/dd/yyyy hh:mm:ss", out DateOnly dateOnly);
                if (conversion)
                    date = dateOnly.ToString();
                return date;
            }
            set
            {
                date = value;
            }
        }
        public double Fee { get; set; }
        public int Nb_Of_Tickets { get; set; }
        public double Total_Fee { get; set; }

    }
}
