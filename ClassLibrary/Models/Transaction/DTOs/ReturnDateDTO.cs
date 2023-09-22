using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Transaction.DTOs
{
    public class ReturnDateDTO
    {
        public string Book_Name { get; set; } = string.Empty;
        public string Return_Date { get; set; } = string.Empty;
        public int Copies { get; set; }
    }
}
