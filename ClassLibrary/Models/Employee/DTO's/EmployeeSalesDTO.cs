using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Employee.DTO_s
{
    public class EmployeeSalesDTO
    {
        public int Employee_Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Books_Sold { get; set; }
        public double Total_Revenue { get; set; }
    }
}
