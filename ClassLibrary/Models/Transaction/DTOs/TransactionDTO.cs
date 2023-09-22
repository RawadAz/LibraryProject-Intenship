using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Transaction.DTOs
{
    public class TransactionDTO
    {
        public int Transaction_Id { get; set; }
        public string Book_Name { get; set; } = string.Empty;
        public int Branch_Id { get; set; }
        public string Client { get; set; } = string.Empty;
        public string Client_Phone_Number { get; set; } = string.Empty;
        public int Employee_Id { get; set; }
        public string Transaction_Date { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Copies { get; set; }
        public double Price { get; set; }
        public double? Late_Penalty { get; set; }
        public double Total_Price { get; set; }
        public string? Return_Date { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}
