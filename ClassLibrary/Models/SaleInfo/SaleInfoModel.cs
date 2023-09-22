namespace ClassLibrary.Models.SaleInfo
{
    public class SaleInfoModel
    {
        public int Id { get; set; } 
        public string Book_Name { get; set; } = string.Empty;
        public string Branch_Name { get; set; } = string.Empty;
        public int Available_Copies { get; set; }
        public double Purchase_Price { get; set; }
        public double Rent_Price { get; set; }
        public string Sale_Type { get; set; } = string.Empty;
    }
}
