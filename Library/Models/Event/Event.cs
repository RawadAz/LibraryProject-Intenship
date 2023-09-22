    namespace Library.Models.Event
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        private string date = string.Empty;

        public string Date
        {
            get
            {
                bool conversion = DateOnly.TryParseExact(date, "MM/dd/yyyy hh:mm:ss", out DateOnly dateOnly );
                if(conversion)
                    date = dateOnly.ToString();
                return date;
                
            }
            set { date = value; }
        }

        public int? Branch_id { get; set; }

        public int Available_seats { get; set; }

        public double Fee { get; set; }
        public string Recurrence { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty; 
    }
}
