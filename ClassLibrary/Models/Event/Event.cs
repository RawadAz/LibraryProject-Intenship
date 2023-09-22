namespace ClassLibrary.Models.Event
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Date { get; set; } = string.Empty;

        public int? Branch_id { get; set; }

        public int Available_seats { get; set; }
        public double Fee { get; set; }
        public string Recurrence { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public override bool Equals(object? obj)
        {
            return obj is Event @event &&
                   Id == @event.Id &&
                   Name == @event.Name &&
                   Date == @event.Date &&
                   Branch_id == @event.Branch_id &&
                   Available_seats == @event.Available_seats &&
                   Recurrence == @event.Recurrence &&
                   Description == @event.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Date, Branch_id, Available_seats, Recurrence, Description);
        }
    }
}
