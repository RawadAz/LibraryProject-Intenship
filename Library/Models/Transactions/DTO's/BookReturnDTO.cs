namespace Library.Models.Transactions.DTO_s
{
    public class BookReturnDTO
    {
        public string Book_Name { get; set; } = string.Empty;

        private string return_Date = string.Empty;
        public string Return_Date
        {
            get
            {
                bool conversion = DateOnly.TryParseExact(return_Date, "MM/dd/yyyy hh:mm:ss", out DateOnly dateOnly);
                if (conversion)
                    return_Date = dateOnly.ToString();
                return return_Date;
            }
        }
        public int Copies { get; set; }
    }
}
