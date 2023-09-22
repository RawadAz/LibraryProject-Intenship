namespace ClassLibrary.Models.Transaction.DTOs
{
    public class EditTransactionDTO
    {
        public string Client_Phone_Number { get; set; } = string.Empty;
        public string Book_Name { get; set; } = string.Empty;
        public string Branch_Name { get; set; } = string.Empty;
        public string Employee_Username { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Copies { get; set; }
        public int? Return_Date_Months { get; set; }
        public double? Late_Penalty_Percentage { get; set; }
        public override bool Equals(object? obj)
        {
            return obj is EditTransactionDTO dTO &&
                   Client_Phone_Number == dTO.Client_Phone_Number &&
                   Book_Name == dTO.Book_Name &&
                   Branch_Name == dTO.Branch_Name &&
                   Employee_Username == dTO.Employee_Username &&
                   Type == dTO.Type &&
                   Copies == dTO.Copies &&
                   Return_Date_Months == dTO.Return_Date_Months &&
                   Late_Penalty_Percentage == dTO.Late_Penalty_Percentage;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Client_Phone_Number);
            hash.Add(Book_Name);
            hash.Add(Branch_Name);
            hash.Add(Employee_Username);
            hash.Add(Type);
            hash.Add(Copies);
            hash.Add(Return_Date_Months);
            hash.Add(Late_Penalty_Percentage);
            return hash.ToHashCode();
        }
    }
}
