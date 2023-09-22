namespace Library.Models.Client
{
    public class Client
    {

        public int Id { get; set; }

        public string First_Name { get; set; } = string.Empty;

        public string Last_Name { get; set; } = string.Empty;

        public string Phone_Number { get; set; } = string.Empty;

        public int Currently_Rented { get; set; }
    }
}
