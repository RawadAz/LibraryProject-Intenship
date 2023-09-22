using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library.Models.Transactions.DTO_s
{
    public class TransactionsDTO
    {
        public int Transaction_Id { get; set; }
        public string Book_Name { get; set; } = string.Empty;
        public int Branch_Id { get; set; }
        public string Client { get; set; } = string.Empty;
        public string Client_Phone_Number { get; set; } = string.Empty;
        public int Employee_Id { get; set; }
        private string transaction_Date = string.Empty;
        public string Transaction_Date
        {
            get
            {
                bool conversion = DateTime.TryParseExact(transaction_Date, "MM/dd/yyyy hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None ,out DateTime dateTime);
                if (conversion)
                    transaction_Date = dateTime.ToString();
                return transaction_Date;
            }
            set
            {
                transaction_Date = value;
            }
        }
        public string Type { get; set; } = string.Empty;
        public int Copies { get; set; }
        public double Price { get; set; }
        public double? Late_Penalty { get; set; }
        public double Total_Price { get; set; }
        private string? return_Date;
        public string? Return_Date
        {
            get
            {
                if (return_Date == null) 
                    return null;

                bool conversion = DateOnly.TryParseExact(return_Date, "MM/dd/yyyy hh:mm:ss", out DateOnly dateOnly);
                if (conversion) 
                    return_Date = dateOnly.ToString();
                return return_Date;
            }
        }
        public string Status { get; set; } = string.Empty;
        
    }
}
