namespace Library.Models.Transactions
{
    public class Transactions
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public int Client_Id { get; set; }
        public int Book_Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public int Copies { get; set; }
        private string return_Date = string.Empty;
        public string Return_Date
        {
            get
            {
                DateOnly dateOnly;
                bool conversion = DateOnly.TryParseExact(return_Date, "MM/dd/yyyy hh:mm:ss", out dateOnly);
                if (conversion)
                    return_Date = dateOnly.ToString();
                return return_Date;
            }
            set
            {
                return_Date = value;
            }
        }
        public double Late_Penalty { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
