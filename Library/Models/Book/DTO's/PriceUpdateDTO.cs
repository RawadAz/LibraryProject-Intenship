namespace Library.Models.Book
{
    public class PriceUpdateDTO
    {
        public string Name { get; set; } = string.Empty;
        public double Purchase_Price { get; set; }
        public double Rent_Price { get; set; }

    }
}
