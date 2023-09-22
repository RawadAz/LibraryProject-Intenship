namespace ClassLibrary.Models.Book.DTO_s
{
    public class TopSellingBook
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Purchase_Price { get; set; }
        public double Rent_Price { get; set; }
        public int In_Stock { get; set; }
        public int Branch_Id { get; set; }
        public string Branch_Name { get; set; } = string.Empty;
        public int Sales { get; set; }
    }
}
