using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Transaction
{
    public class Transactions
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public int Client_Id { get; set; }
        public int Book_Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public int Copies { get; set; }
        public string Return_Date { get; set; } = string.Empty;
        public double Late_Penalty { get; set; }
        public string Status { get; set; } = string.Empty;

        public override bool Equals(object? obj)
        {
            return obj is Transactions transactions &&
                   Id == transactions.Id &&
                   Employee_Id == transactions.Employee_Id &&
                   Client_Id == transactions.Client_Id &&
                   Book_Id == transactions.Book_Id &&
                   Type == transactions.Type &&
                   Copies == transactions.Copies &&
                   Return_Date == transactions.Return_Date &&
                   Late_Penalty == transactions.Late_Penalty;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Employee_Id, Client_Id, Book_Id, Type, Copies, Return_Date, Late_Penalty);
        }
    }
}
