using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Dashboard
{
    public class DashboardSalesInfo
    {
        public double Total_Revenue { get; set; }
        public int Total_sales { get; set; }
        public int Books_Sold { get; set; }
        public int Books_Rented { get; set; }
        public int Rented_Now { get; set; }
    }
}
