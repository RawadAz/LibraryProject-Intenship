namespace Library.Models.Transactions.DTO_s
{
    public class EditTransactionsDTO
    {
        public string Client_Phone_Number { get; set; } = string.Empty;
        public string Book_Name { get; set; } = string.Empty;
        public string Branch_Name { get; set; } = string.Empty;
        public string Employee_Username { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Copies { get; set; }
        public int? Return_Date_Months { get; set; }
        public double? Late_Penalty_Percentage { get; set; }
    }
}
